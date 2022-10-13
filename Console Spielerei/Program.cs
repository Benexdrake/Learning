namespace Console_Spielerei
{
    class Program
    {
        public static async Task Main()
        {
            Test t = new();

            List<string> filePaths = new();

            string mainPath = "C:\\Users\\RichterB\\Desktop";
            string searchPath = Path.Combine(mainPath, "Ordner");
            string outputPath = Path.Combine(mainPath, "Output");
            string savePath = Path.Combine(outputPath, "Combined");

            string zipPath = Path.Combine(outputPath, "zip");
            string unZipPath = Path.Combine(outputPath, "unzip");

            t.directoriesPathList.Add(searchPath);






            // Sucht nach Ordnern
            t.FindDirectories(searchPath);

            // Ausgabe aller gefundenen Ordner
            foreach (var path in t.directoriesPathList)
            {
                Console.WriteLine(path);
                // durchsucht jeden Ordner nach .txt Dateien
                var files = t.FindFile(path, "txt").Result;

                // Gefundene Dateien werden in eine Liste gespeichert.
                foreach (var f in files)
                {
                    filePaths.Add(f);
                }
            }
            
            foreach (var f in filePaths)
            {
                // Trennt den Pfad von dem Dateinamen
                // Dateiname
                string file = t.GetFileName(f);
                // Ordnerpfad
                string filePath = t.GetPathName(f);

                // Bewegt die gefundenen Dateien aus dem Ordnerpfad in einen neuen Ordner.
                t.MoveFile(filePath,outputPath,file);
            }

            // Sucht alle Dateien aus dem Ordner Output mit der Endung .txt
            var outputFiles = t.FindFile(outputPath,"txt").Result;

            foreach (var file in outputFiles)
            {
                var readFile = t.ReadFile(file);

                // Sortiert Einträge nach Suchparameter und speichert diese in eigene Dateien.
                await t.SaveFile(readFile.ToArray(), "ABSCHNITT", savePath, "csv");
                await t.SaveFile(readFile.ToArray(), "ARZTGRUPPEN", savePath, "csv");
            }


            // Suchen nach .Zip Dateien im Ordner Ordner

            var zipFiles = t.FindFile(searchPath,"zip").Result;

            foreach (var zip in zipFiles)
            {
                // kopieren der Dateien nach Output\zip
                // Trennt den Pfad von dem Dateinamen
                // Dateiname
                string file = t.GetFileName(zip);
                // Ordnerpfad
                string filePath = t.GetPathName(zip);
                // Bewegt die gefundenen Dateien aus dem Ordnerpfad in einen neuen Ordner.
                t.MoveFile(filePath, zipPath, file);
            }


            // Sucht nach .zip Dateien im zip Ordner
            zipFiles = t.FindFile(zipPath, "zip").Result;

            foreach (var zip in zipFiles)
            {
                // Entpackt Dateien im unzip Ordner
                t.UnpackZip(zip, unZipPath);
            }

        }
    }
}