using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;

namespace PDF_Splitter
{
    public class PDFSplitter
    {
        
        private int IsNumber(string site)
        {
            bool isNumber = int.TryParse(site, out var number);

            if(isNumber)
                return number;
            return 0;
        }

        public async Task<string[]> FindDocuments()
        {
            if (!Directory.Exists("Files"))
            {
                Directory.CreateDirectory("Files");
                Console.WriteLine("File Direcotory created");
            }
            return Directory.GetFiles("Files");
        }

        public async Task Split(string siteLine, string file)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            List<int> siteList = new List<int>();

            var sites = siteLine.Split(';');

            foreach (var site in sites)
            {
                siteList.Add(IsNumber(site));
            }

            var fileName = file.Split('\\').Last().Split('.').First();

            if(!Directory.Exists($"Files\\{fileName}"))
                Directory.CreateDirectory($"Files\\{fileName}");

            if(file != String.Empty)
            {
                PdfDocument pdf = PdfReader.Open(file, PdfDocumentOpenMode.Import);

                int site = 1;
                for (int i = 0; i < sites.Length; i++)
                {
                    PdfDocument result = new PdfDocument();
                    
                    int a = site;
                    for (int j = a; j < a + siteList[i]; j++)
                    {
                        result.AddPage(pdf.Pages[j]);
                        site++;
                    }
                    result.Save($"Files\\{fileName}\\{i+1}.pdf");
                }
            }
            else
            {
                Console.WriteLine("No File found!");
            }
        }

    }
}
