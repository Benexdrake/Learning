using System.IO.Compression;
using System.IO.Enumeration;

namespace Console_Spielerei;
public class Test
{
    int folderNumber;
    public string ZipFolderName { get; set; } = "Gezippt";
    public string UnzipFolderName { get; set; } = "Ungezippt";
    public string MappingFolderName { get; set; } = "Bereitstellung";

    public Test()
    {
        folderNumber = 1;
    }

    // Kopieren der Dateien von einem Download Ordner in einen Gezippt Ordner

    // filesFolder like = F:\BenR\download
    // targetFolder like = F:\BenR\Demo\Gradient-Abrechnung 1\06_EBM2000+\# Strecke ASV\ASV Leistungsstammdaten\2022\2022_4\Stand_18.10.2022\

    // Um überschreibungen zu vermeiden werden Gezippt_Nummer Ordner erstellt z.B. Gezippt_1, Gezippt_2
    // Um die Zahl auszulesen wird Gezippt_ entfernt und die Zahl Parsed +1 für den nächsten Ordner
    public async Task CopyZipFilesAsync(string filesFolder, string targetFolderPath)
    {
        // Standard Name Gezippt_1 falls es noch keinen Ordner gibt, wird überschrieben falls es doch existiert
        string target = $"{ZipFolderName}_{folderNumber}";

        // Sucht Dateien mit der Endung xyz z.B zip oder csv
        var zipFiles = FindFiles(filesFolder, "zip");

        // Durchsucht den TargetFolder nach Ordnern die Gezippt heissen

        var zipFolders = FindDirectories(targetFolderPath, ZipFolderName);

        // Sollte es schon Ordner geben wird der letzte der Liste genutzt und seine Nummer geparsed

        if (zipFolders.Length > 0)
        {
            string foldername = string.Empty;
            int temp = 0;
            foreach (var zipFolder in zipFolders)
            {
               foldername = DirectoryName(zipFolder);
               int number = FindNumber(foldername);
                if(number > temp)
                    temp = number;
            }
            folderNumber = (temp+1);
            target = ZipFolderName + "_" + folderNumber;

            // Erstell die Ordner für Bereitstellung und Ungezippt, überprüft aber vorher, ob diese schon existieren, wenn ja wird abgebrochen.

            if (DirectoryExist(targetFolderPath, ZipFolderName) || DirectoryExist(targetFolderPath, ZipFolderName))
            {
                return;
            }
        }

        // Ein neuer Gezippt Ordner wird erstellt, als Name wird folgenes passieren Gezippt_Nummer <-folderNumber

        // targetFolderPath = ASV Leistungsstammdaten\2022\2022_4\Stand_18.10.2022\
        // target = Gezippt_1
        // NewPath = ASV Leistungsstammdaten\2022\2022_4\Stand_18.10.2022\Gezippt_1
        string newPath = $"{targetFolderPath}\\{target}";
        CreateDirectory(newPath);
        CreateDirectory($"{targetFolderPath}\\{UnzipFolderName}_{folderNumber}");
        CreateDirectory($"{targetFolderPath}\\{MappingFolderName}_{folderNumber}");

        // Dateien werden vom FilesFolder in den neuangelegten TargetFolderPath + NeuerOrdnername kopiert
        // z.B. 2022\2022_4\Stand_18.10.2022\Gezippt_1

        foreach (var files in zipFiles)
        {
            await CopyFiles(files, newPath);
        }
        Console.WriteLine();
    }

    // Entpacken der .Zip Dateien von einem Gezippt Ordner in einen Ungezippt Ordner

    public async Task UnzipFilesAsync(string from)
    {
        // Sucht alle .zip Dateien
        var zipFiles = FindFiles($"{from}\\{ZipFolderName}_{folderNumber}", "zip");

        foreach (var file in zipFiles)
        {
            await UnzipFile(file, $"{from}\\{UnzipFolderName}_{folderNumber}");
        }
    }

    // Mapping der Dateien aus Ungezippt in einen Mapping Ordner

    public async Task MappingFilesAsync(string path)
    {
        string[] fileNames = { "ABSCHNITT1", "ABSCHNITT2", "ARZTGRUPPEN_CODE", "SCHLUESSELGUELTIGKEIT" };

        var files = FindFiles($"{path}\\{UnzipFolderName}_{folderNumber}", "csv");

        foreach (var search in fileNames)
        {
            await SaveFiles(files, search, path);
        }
    }



    #region Private Methods

    private async Task SaveFiles(string[] files, string searchTerm, string path)
    {
        var newText = files.Where(x => x.Contains(searchTerm)).ToList();

        await File.WriteAllLinesAsync(Path.Combine($"{path}\\{MappingFolderName}_{folderNumber}", $"{searchTerm}.csv"), newText);
    }

    private string[] FindDirectories(string path, string searchTerm)
    {
        var allDs = Directory.GetDirectories(path);

        return allDs.Where(x => x.Contains(searchTerm)).ToArray();
    }

    private string[] FindFiles(string path, string searchTerm)
    {
        var files = Directory.GetFiles(path, $"*.{searchTerm}");
        return files;
    }

    private int FindNumber(string folderName)
    {
        var result = folderName.Replace($"{ZipFolderName}_", "");
        bool isNumber = int.TryParse(result, out var number);

        if (isNumber)
            return number;
        return 0;
    }

    private async Task CopyFiles(string from, string to)
    {
        var filename = Path.GetFileName(from);

        File.Copy(from, $"{to}\\{filename}", true);
    }

    private async Task UnzipFile(string zipFile, string unzipFolder)
    {
        ZipFile.ExtractToDirectory(zipFile, unzipFolder);
    }

    private string DirectoryName(string path)
    {
        return new DirectoryInfo(path).Name;
    }

    private bool DirectoryExist(string path, string folderName)
    {
        var directoryName = new DirectoryInfo(path).Name;

        if (directoryName.Contains(folderName))
        {
            return true;
        }
        return false;
    }

    private void CreateDirectory(string path)
    {
        if (!Directory.Exists(path))
            Directory.CreateDirectory(path);
    }

    private string GetDirectoryPath(string path)
    {
        return new DirectoryInfo(path).FullName;
    }


    #endregion

}
