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
                string result = path + "\\" + dir.Name;
                directoriesPathList.Add(result);
                FindDirectories(result);
            }
        }

        // Findet alle Lesbaren Dateien in einem Ordner, liesst diese ein und speichert die Zeilen als
        public IEnumerable<string> ReadFile(string path)
        {
            foreach (var file in Directory.GetFiles(path))
            {
                foreach (var zeile in File.ReadLines(file))
                {
                    yield return zeile;
                }
            }
        }

        // Sortiert Liste nach Suchparameter und speichert diese ab.
        public async Task SaveFile(string[] files, string search, string savePath)
        {
            if(!Directory.Exists(savePath))
                Directory.CreateDirectory(savePath);

            var newText = files.Where(x => x.Contains(search)).ToList();

            await File.WriteAllLinesAsync(savePath + $"\\{search}.csv", newText);
        }
    }
}
