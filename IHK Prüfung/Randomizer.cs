using System.Reflection;

namespace IHK_Prüfung
{
    public class Randomizer
    {
        public void Start(Helper.Exam exam)
        {
            List<string> paths = new List<string>();

            string ExeFilePath = Assembly.GetExecutingAssembly().Location;
            ExeFilePath = ExeFilePath.Substring(0, ExeFilePath.Length - 15);

            string srcPath = ExeFilePath + "src";

            Helper.CheckForDirectory(srcPath);

            string examPath = string.Empty;
            int count = 5;
            switch(exam)
            {
                case Helper.Exam.GA1_AE:
                    examPath = srcPath + "\\GA1_AE";
                    break;
                case Helper.Exam.GA1_SI:
                    examPath = srcPath + "\\GA1_SI";
                    break;
                case Helper.Exam.GA2:
                    examPath = srcPath + "\\GA2";
                    break;
                case Helper.Exam.AP1:
                    examPath = srcPath + "\\AP1";
                    count = 4;
                    break;
            }
            Helper.CheckForDirectory(examPath);
            
            // Sammelt die Ordner als Dateipfad ab um eine Liste daraus zu machen
            var filePaths = Directory.GetDirectories(examPath, "*", System.IO.SearchOption.AllDirectories);

            foreach (string path in filePaths)
            {
                // Hier wird überprüft ob alle Dateien vorhanden sind, fehlt eine oder mehr Dateien, wird der Ordner nicht eingetragen
                if (Helper.CheckForFiles(path, count))
                {
                    paths.Add(path);
                }
                
            }

            if(paths.Count >0)
            {
                var newPaths = Helper.Randomize(paths.ToArray(), count);
                Helper.PDFConverter(newPaths, exam);
            }
            else
            {
                Console.WriteLine("Keine Dateien gefunden");
            }
        }
    }
}
