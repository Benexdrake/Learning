using System.IO.Compression;

namespace Console_Spielerei
{
    public class Test
    {
        public List<string> directoriesPathList = new List<string>();

        // Finde alle Ordner in einem Ordner, dessen Ordner usw.
        public void FindDirectories(string path)
        {
            foreach (var directory in Directory.GetDirectories(path))
            {
                var dir = new DirectoryInfo(directory);
                string result = Path.Combine(path, dir.Name);
                directoriesPathList.Add(result);
                FindDirectories(result);
            }
        }

        // Sucht nach Dateien in einem Ordner und gibt den Pfad als String zurück.
        public async Task<string[]> FindFile(string path, string searchParameter)
        {
            return Directory.GetFiles(path, $"*.{searchParameter}");
        }

        // Liest alles aus einer Datei aus.
        public string[] ReadFile(string file)
        {
            return File.ReadAllLines(file);
        }

        // Sortiert Liste nach Suchparameter und speichert diese ab.
        public async Task SaveFile(string[] files, string search, string savePath, string extension)
        {
            if (!Directory.Exists(savePath))
                Directory.CreateDirectory(savePath);

            var newText = files.Where(x => x.Contains(search)).ToList();

            await File.WriteAllLinesAsync(Path.Combine(savePath, $"{search}.{extension}"), newText);
        }

        // Bewegt dateien aus einem Ordner zu einem anderen, falls dieser nicht existiert, wird er erstellt
        public async Task MoveFile(string fromPath, string toPath, string file)
        {
            string moveFrom = Path.Combine(fromPath, file);
            string moveTo = Path.Combine(toPath, file);

            if (!Directory.Exists(toPath))
            {
                Directory.CreateDirectory(toPath);
            }

            File.Move(moveFrom, moveTo, true);
        }

        // Entpackt eine Datei in einen angegebenen Ordner
        public async Task UnpackZip(string file, string path)
        {
            ZipFile.ExtractToDirectory(file, path);
        }

        // Dateinamen filtern
        public string GetFileName(string filePath)
        {
            return Path.GetFileName(filePath);
        }

        // Dateipfad ohne Dateinamen
        public string GetPathName(string filePath)
        {
            string filename = GetFileName(filePath);

            int max = filePath.Length - filename.Length;

            return filePath.Substring(0, max);
        }
    }
}
