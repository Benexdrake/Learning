using Microsoft.AspNetCore.Mvc;

namespace BlazorASV.Data
{
    public class MappingController : Controller
    {
        public IActionResult MakeTheMagicHappen(string mainPath, int quartal, string downloadPath)
        {
            Logic l = new Logic();
            string[] filenames = { "ABSCHNITT", "ARZTGRUPPEN_CODE"};
            
            string rootPath = mainPath + $"\\{DateTime.Now.Year}\\{DateTime.Now.Year}_{quartal}\\Stand_{DateTime.Now.ToString("dd.MM.yyyy")}";
            string zipPath = rootPath + "\\zip";
            string unzipPath = rootPath + "\\unzip";
            string mappingPath = rootPath + "\\appendix-match";
            
            var files = l.FindDownloadFiles(downloadPath);

            var config = Helper.LoadConfig();

            var asvList = l.GetFiles(config.Archiv).Result;

            l.DownloadFiles(asvList, config.DownloadFolder);

            var zipfiles = l.FindZipFiles(zipPath);
            
            l.UnzipFiles(unzipPath, zipfiles);
            
            var csv = l.FindCSVFiles(unzipPath);
            
            foreach (var file in filenames)
            {
                List<string> result = new();
                foreach (var c in csv)
                {
                    var read = l.ReadFile(c);
                    foreach (var r in read)
                    {
                        result.Add(r);
                    }
                }
                l.CombineFiles(mappingPath, result.ToArray(), file);
            }
            return Ok();
        }
    }
}
