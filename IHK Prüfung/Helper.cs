using Newtonsoft.Json;
using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;

namespace IHK_Prüfung
{
    public class Helper
    {
        public enum Exam
        {
            GA1_AE, GA1_SI, GA2, AP1
        }

        public static bool CheckForFiles(string filePath, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                // Überprüft ob es 4(AP1) oder 5 GA1-2 Dateien gibt, die in Handlungsschritten unterteilt wurden
                string pdf = filePath + @"\" + i + ".pdf";
                if(!File.Exists(pdf))
                {
                    return false;
                }
            }
            return true;
        }

        public static void CheckForDirectory(string directory)
        {
            // Überprüft ob ein Ordner existiert, wenn nicht, wird dieser erstellt.
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
        }

        public static string[] Randomize(string[] filePaths, int count)
        {
            Random random = new Random();

            List<string> newFilePaths = new List<string>();

            for (int i = 1; i <= count; i++)
            {
                newFilePaths.Add(filePaths[random.Next(0,filePaths.Length)]+$"\\{i}.pdf");
            }

            return newFilePaths.ToArray();
        }
        public static void PDFConverter(string[] pdfFiles, Exam exam)
        {
            string ExeFilePath = Assembly.GetExecutingAssembly().Location;
            ExeFilePath = ExeFilePath.Substring(0, ExeFilePath.Length - 15);

            if (!Directory.Exists(ExeFilePath + "out"))
            {
                Directory.CreateDirectory(ExeFilePath + "out");
            }

            // Damit der Dateiname mit AP1, GA1, GA2 usw anfängt.
            string fileName = exam.ToString() + "_";

            // Unterteil den pdf datei Pfad und bekommt so den Namen des Ordners als Dateiname z.B. SO-15 für Sommer 2015
            foreach (var item in pdfFiles)
            {
                var split = item.Split('\\');
                fileName += split[split.Length - 2] + "_";
            }
            fileName += DateOnly.FromDateTime(DateTime.Now);

            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            PdfDocument one = PdfReader.Open(pdfFiles[0], PdfDocumentOpenMode.Import);
            PdfDocument two = PdfReader.Open(pdfFiles[1], PdfDocumentOpenMode.Import);
            PdfDocument three = PdfReader.Open(pdfFiles[2], PdfDocumentOpenMode.Import);
            PdfDocument four = PdfReader.Open(pdfFiles[3], PdfDocumentOpenMode.Import);
            PdfDocument five = new PdfDocument();
            if (exam != Exam.AP1)
                five = PdfReader.Open(pdfFiles[4], PdfDocumentOpenMode.Import);

            using (PdfDocument outPdf = new PdfDocument())
            {
                CopyPages(one, outPdf);
                CopyPages(two, outPdf);
                CopyPages(three, outPdf);
                CopyPages(four, outPdf);
                if(exam != Exam.AP1)
                    CopyPages(five, outPdf);

                // Speichert die neue PDF in den Out Ordner ab
                outPdf.Save(ExeFilePath + $"out\\{fileName}.pdf");
            }

            // Öffnet den Out Ordner
            Process.Start("explorer.exe",ExeFilePath + "out");
        }

        static void CopyPages(PdfDocument from, PdfDocument to)
        {
            for (int i = 0; i < from.PageCount; i++)
            {
                to.AddPage(from.Pages[i]);
            }
        }


        public static void PDFSplitter(string filepath, int[] site, int[] sitecount )
        {
            var split = filepath.Split('\\');
            string fileName = split[split.Length-1];

            Console.WriteLine(fileName);

        }
    }
}
