
using System.IO;
using System.IO.Compression;

using File = System.IO.File;

namespace ASVConsole
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
            var files = Directory.GetFiles(path, "*.zip");
            return files;
        }

        public string[] FindCSVFiles(string path)
        {
            CreateDirectory(path);
            var files = Directory.GetFiles(path, "*.csv");
            return files;
        }

        public async Task DownloadFiles(string[] urls, string path)
        {
            //Faked den Download und kopiert die Dateien von einem Ort zum anderen
            foreach (var url in urls)
            {
                File.Copy(url, path + "\\" +Path.GetFileName(url), true);
            }
        }

        public void UnzipFiles(string unzipPath, string[] files)
        {
            foreach (var file in files)
            {
                ZipFile.ExtractToDirectory(file, unzipPath,true);
            }
        }

        public void CombineFiles(string path, string[] files)
        {

        }

        public void CreateDirectory(string path)
        {
            if(!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }
    }
}
