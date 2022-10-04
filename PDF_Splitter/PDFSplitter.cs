using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace PDF_Splitter
{
    public class PDFSplitter
    {
        public string FilePath { get; set; } = "Files"; // Files\AP1 oder Files\GA1-AE oder Files\GA1-SI oder Files\GA2
        public PDFSplitter()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
        }

        public void Start(string directory)
        {
            if (directory != string.Empty)
                FilePath += $"\\{directory}";

            if (Directory.Exists(FilePath))
            {
                var config = LoadConfig();
                var result = new List<IHKPDF>();

                foreach (var item in config)
                {
                    if (FileExists(item.FileName))
                    {
                        result.Add(new IHKPDF()
                        {
                            FileName = item.FileName,
                            Sites = item.Sites
                        });
                    }
                    else
                    {
                        Console.WriteLine($"File {item.FileName} not found");
                    }
                }

                foreach (var item in result)
                {
                    SplitPDF(item.FileName, item.Sites);
                }
            }
            else
            {
                Console.WriteLine($"Directory: {directory} dont exist");
            }
        }

        public string[] LoadSites()
        {
            var sites = File.ReadAllLines("Config.txt");
            return sites;
        }

        public IHKPDF[] LoadConfig()
        {
            string[] file = new string[1];
            List<IHKPDF> iHKPDFs = new List<IHKPDF>();

            if(File.Exists($"{FilePath}\\Config.txt"))
            {
                file = File.ReadAllLines($"{FilePath}\\Config.txt");


                foreach (var f in file)
                {
                    var split = f.Split(';');
                    if (split.Length > 0)
                    {
                        var sites = new List<int>();
                        for(int i = 1; i < split.Length; i++)
                        {
                            sites.Add(IsNumber(split[i]));
                        }
                        iHKPDFs.Add(new IHKPDF()
                        {
                            FileName = split[0],
                            Sites = sites.ToArray()
                        });
                    }
                }
                
            }
            else
            {
                File.Create($"{FilePath}\\Config.txt");
            }
            return iHKPDFs.ToArray();
        }
        
        private int IsNumber(string site)
        {
            bool isNumber = int.TryParse(site, out var number);

            if(isNumber)
                return number;
            return 0;
        }

        public bool FileExists(string file)
        {
            return File.Exists($"{FilePath}\\" + file + ".pdf");
        }

        public async Task<string[]> FindDocuments()
        {
            if (!Directory.Exists(FilePath))
            {
                Directory.CreateDirectory(FilePath);
                Console.WriteLine("File Direcotory created");
            }
            return Directory.GetFiles(FilePath);
        }

        public void SplitPDF(string file, int[] sites)
        {
            if (file != String.Empty)
            {
                PdfDocument pdf = PdfReader.Open(FilePath + "\\" + file+".pdf", PdfDocumentOpenMode.Import);

                if (!Directory.Exists($"{FilePath}\\{file}"))
                    Directory.CreateDirectory($"{FilePath}\\{file}");

                int site = 1;
                for (int i = 0; i < sites.Length; i++)
                {
                    PdfDocument result = new PdfDocument();

                    int a = site;
                    for (int j = a; j < a + sites[i]; j++)
                    {
                        result.AddPage(pdf.Pages[j]);
                        site++;
                    }
                    result.Save($"{FilePath}\\{file}\\{i + 1}.pdf");
                }
            }
            else
            {
                Console.WriteLine("No File found!");
            }
        }
    }
}
