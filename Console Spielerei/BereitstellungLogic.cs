using System.IO.Compression;
using System.Text.RegularExpressions;

namespace Console_Spielerei;
public class BereitstellungLogic 
{
    int folderNumber;
    public string ZipFolderName { get; set; } = "Gezippt";
    public string UnzipFolderName { get; set; } = "Ungezippt";
    public string MappingFolderName { get; set; } = "Bereitstellung";

    public BereitstellungLogic()
    {
        folderNumber = 1;
    }

    public IEnumerable<Group> GetFolderList(string stammverzeichnis)
    {
        var groups = new List<Group>();
        var directories = new DirectoryInfo(stammverzeichnis).GetDirectories();
        foreach (var directory in directories)
        {
            FindDirectories(directory, null, groups);
        }
        return groups;
    }

    // Path ist der Ordner Stand_Datum, darin befindet sich ein Gezippt, Ungezippt_X und Bereitstellung_X Ordner
    public async Task Start(string path, string mappingVorquartalFolder, string repoPath)
    {
        // Step 1:
        // Überprüfen welcher der letzte Ungezippt_X Ordner ist, Nummer +1
        CheckForFolderNumber(path);


        // Step 2:
        // Entzippen der Dateien aus Gezippt in Ungezippt
        await UnzipFilesAsync(path);

        //Step 3:
        // Verbinden der asv Dateien aus Ungezippt und speichern dieser in Bereitstellung
        await MappingFilesAsync(path);

        //Step 4:
        // Einlesen der gemappten/appendix Dateien, Abschnitt1/2, Arztgruppen_Code und Schlüsselgültigkeit, als Liste der passenden Models
       
        var agc = GetAGC(path);
        


        //Step 5:
        // Die List Models zu einer agc_fgc mapping/appendix Datei convertieren und als .csv speichern.
        AppendixAGC_FGC(agc);

    }


    #region Private Methods

    private void CheckForFolderNumber(string path)
    {
        var folder = FindDirectories(path, UnzipFolderName);
        if (folder.Length > 0)
        {
            var number = FindNumber(DirectoryName($"{path}\\{folder[folder.Length - 1]}"));
            folderNumber = number + 1;
        }

        CreateDirectory($"{path}\\{ZipFolderName}");
        CreateDirectory($"{path}\\{UnzipFolderName}_{folderNumber}");
        CreateDirectory($"{path}\\{MappingFolderName}_{folderNumber}");
    }
 
    // From sollte der Stand_Datum Ordner sein.
    private async Task UnzipFilesAsync(string from)
    {
        // Sucht alle .zip Dateien
        var zipFiles = FindFiles($"{from}\\{ZipFolderName}", "zip");

        foreach (var file in zipFiles)
        {
            await UnzipFile(file, $"{from}\\{UnzipFolderName}_{folderNumber}");
        }
    }

    // Mapping der Dateien aus Ungezippt in einen Mapping Ordner
    private async Task MappingFilesAsync(string path)
    {
        string[] fileNames = { "ABSCHNITT1", "ABSCHNITT2", "ARZTGRUPPEN_CODE", "SCHLUESSELGUELTIGKEIT" };

        var files = FindFiles($"{path}\\{UnzipFolderName}_{folderNumber}", "csv");

        foreach (var search in fileNames)
        {
            await SaveFiles(files, search, path);
        }
    }

    // 4 Klassen zum Lesen der gemappten Dateien als Liste von Objekten




    private Arztgruppen_Code[] GetAGC(string path)
    {
        string fileName = "ABSCHNITT1";
        List<Arztgruppen_Code> list = new();
        var folder = $"\\{MappingFolderName}{folderNumber}";

        var files = File.ReadAllLines(path + folder).Where(x => x.Contains(fileName)).ToList();
        if (files.Count > 0)
        {
            foreach (var file in files)
            {
                var asv = file.Split('#');
                list.Add(new()
                {
                    Satzart = asv[0],
                    ZeitraumID = asv[1],
                    Arztgruppe = asv[2],
                    BeginnZeitraum = asv[3],
                    EndeZeitraum = asv[4],
                    ArztgruppenCode = asv[5],
                    ZusatzlicheArztgruppe = asv[6],
                    Stand = asv[7]
                });
            }
        }
        return list.ToArray();
    }



    private void AppendixAGC_FGC(Arztgruppen_Code[] agc)
    {
        // Zusammenführen der Spalten als neue .csv Datei.
    }

    private async Task SaveFiles(string[] files, string searchTerm, string path)
    {
        var list = new List<string>();
        var newText = files.Where(x => x.Contains(searchTerm)).ToList();

        foreach (var file in newText)
        {
            var text = File.ReadAllLines(file);
            list.AddRange(text);
        }

        await File.WriteAllLinesAsync(Path.Combine($"{path}\\{MappingFolderName}_{folderNumber}", $"{searchTerm}.csv"), list);
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
        var result = folderName.Replace($"{UnzipFolderName}_", "");
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
