
using System.IO;
using System.IO.Compression;

using File = System.IO.File;

namespace BlazorASV.Data
{
    internal class Logic
    {
        public Logic()
        {
        }

        public string[] FindDownloadFiles(string url)
        {
            var files = Directory.GetFiles(url, "*.zip");
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

        public void DownloadFiles(string[] urls, string path)
        {
            //Faked den Download und kopiert die Dateien von einem Ort zum anderen
            CreateDirectory(path);
            foreach (var url in urls)
            {
                File.Copy(url, path + "\\" + Path.GetFileName(url), true);
            }
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
    }
}
