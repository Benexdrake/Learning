using HtmlAgilityPack;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.IO.Compression;
using System.Net;
using File = System.IO.File;

namespace BlazorASV.Data
{
    internal class Logic
    {
        WebDriver driver;
        public Logic()
        {
            driver = Firefox();
        }

        public static FirefoxDriver Firefox()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.AddArgument("--headless");
            options.AddArgument("--enable-precise-memory-info");
            options.AddArgument("--disable-popup-blocking");
            options.AddArgument("--enable-precise-memory-info");
            options.AddArgument("--blink-settings=imagesEnabled=false");
            options.AddArgument("--enable-javascript");
            options.AddArgument("--block-new-web-contents");
            FirefoxDriverService FService = FirefoxDriverService.CreateDefaultService();
            FService.HideCommandPromptWindow = true;

            return new FirefoxDriver(FService, options);
        }

        public string[] FindDownloadFiles(string url)
        {
            var files = Directory.GetFiles(url, "*.zip").Where(x => x.Contains("ASV")).ToArray();
            return files;
        }

        public string[] FindZipFiles(string path)
        {
            CreateDirectory(path);
            var files = Directory.GetFiles(path, "*.zip");
            return files;
        }

        public string[] FindCSVFiles(string path)
        {
            CreateDirectory(path);
            var files = Directory.GetFiles(path, "*.csv");
            return files;
        }

        public async Task<List<ASV>> GetFiles(bool wantArchive)
        {
            Console.WriteLine("Searching for Files now...");
            string url = "https://institut-ba.de/service/asvabrechnung/asvabrechnungcsv.html";

            List<ASV> ASVList = new();

            driver.Navigate().GoToUrl(url);

            driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/div/div/div/div[2]/div/form/p[3]/input")).Click();
            Console.WriteLine("Clicked on Checkbox");

            driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/div/div/div/div[2]/div/form/p[4]/input")).Click();
            Console.WriteLine("Clicked on Button");

            string html = driver.PageSource;

            var doc = new HtmlDocument();
            doc.LoadHtml(html);

            var mainList = FindNodesByDocument(doc, "div", "style", "display:block; border:1px solid #d2e6f3; padding:5px").Result;

            foreach (var list in mainList)
            {
                var split = list.InnerText.Split('\n');

                string title = split[2].Replace("Indikation: ", "");

                var main = FindNodesByNodeEqual(list, "td", "style", "padding:4px;").Result;

                ASVList.Add(new ASV()
                {
                    FileUrl = main[3].InnerHtml.Substring(9, 68),
                    FileName = main[3].InnerText.Replace("\r\n", ""),
                    IsArchivFile = false
                });
                if (wantArchive)
                {
                    var archivList = FindNodesByNode(list, "tr", "style", "background-color: #").Result;
                    foreach (var archivNode in archivList)
                    {
                        var archiv = FindNodesByNode(archivNode, "td", "style", "padding:2px;").Result;
                        ASVList.Add(new ASV()
                        {
                            FileUrl = archiv[3].InnerHtml.Substring(9, 68),
                            FileName = archiv[3].InnerText.Replace("\r\n", ""),
                            IsArchivFile = true
                        }); ;
                    }
                }
            }
            Console.WriteLine($"Found {ASVList.Count} Files");
            return ASVList;
        }

        public async Task DownloadFiles(List<ASV>ASVList, string saveFolder)
        {
            int i = 1;
            WebClient client = new WebClient();
            foreach (var item in ASVList)
            {
                int procent = Procent(i, ASVList.Count);

                string procentMessage = $"{procent}% / 100%";

                if (procent < 10)
                {
                    procentMessage = $"  {procent}% / 100%";
                }
                else if (procent < 100)
                {
                    procentMessage = $" {procent}% / 100%";
                }

                if (item.IsArchivFile)
                {
                    var filenameSplit = item.FileName.Split('_');
                    string archivPath = $"{saveFolder}\\Archiv\\{filenameSplit[1]}";
                    if (!Directory.Exists(archivPath))
                        Directory.CreateDirectory(archivPath);
                    client.DownloadFile(item.FileUrl, archivPath + "\\" + item.FileName);
                    string archiv = String.Format(" | {0,5} | {1,5} | {2,5} | ", procentMessage, "Saved in Archiv", item.FileName);
                    Console.WriteLine(archiv);
                    i++;
                    continue;
                }
                client.DownloadFile(item.FileUrl, saveFolder + "\\" + item.FileName);

                string text = String.Format(" | {0,5} | {1,5} | {2,5} | ", procentMessage, " Saved in Main ", item.FileName);
                Console.WriteLine(text);
                i++;
            }
            Console.WriteLine("Download Completed!");
            driver.Quit();
        }

        public void UnzipFiles(string unzipPath, string[] files)
        {
            CreateDirectory(unzipPath);
            foreach (var file in files)
            {
                ZipFile.ExtractToDirectory(file, unzipPath,true);
            }
        }

        public string[] ReadFile(string file)
        {
            return File.ReadAllLines(file);
        }

        public async Task CombineFiles(string savePath, string[] files, string search)
        {
            CreateDirectory(savePath);

            var newText = files.Where(x => x.Contains(search)).ToList();

            await File.WriteAllLinesAsync(Path.Combine(savePath, $"{search}.csv"), newText);
        }

        public void CreateDirectory(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        private int Procent(int n, int max)
        {
            return (int)Math.Round((double)(100 * n) / max);
        }

        async Task<List<HtmlNode>> FindNodesByNode(HtmlNode node, string a, string b, string c)
        {
            return node.Descendants(a).Where(node => node.GetAttributeValue(b, "").Contains(c)).ToList();
        }

        async Task<List<HtmlNode>> FindNodesByNodeEqual(HtmlNode node, string a, string b, string c)
        {
            return node.Descendants(a).Where(node => node.GetAttributeValue(b, "").Equals(c)).ToList();
        }

        async Task<List<HtmlNode>> FindNodesByDocument(HtmlDocument document, string a, string b, string c)
        {
            return document.DocumentNode.Descendants(a).Where(node => node.GetAttributeValue(b, "").Contains(c)).ToList();
        }
    }
}
