using ASVConsole;

Logic l = new Logic();

int quartal = 4;
string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
string rootPath = desktop + $"\\{DateTime.Now.Year}\\{DateTime.Now.Year}_{quartal}\\Stand_{DateTime.Now.ToString("dd.MM.yyyy")}";
string zipPath = rootPath + "\\zip";
string unzipPath = rootPath + "\\unzip";

l.CreateDirectory(rootPath);
l.CreateDirectory(zipPath);
l.CreateDirectory(unzipPath);

Console.WriteLine(zipPath);

var files = l.FindDownloadFiles("D:\\Institut-ba.de");

await l.DownloadFiles(files, zipPath);
var zipfiles = l.FindZipFiles(zipPath);

l.UnzipFiles(unzipPath, zipfiles);

var f = l.FindCSVFiles(unzipPath);

Console.WriteLine();
