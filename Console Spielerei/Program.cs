using Console_Spielerei;

List<Group> groups = new List<Group>();

// Start Directory
FindDirectories("D:\\Eigene Projekte");

string FindDirectories(string path)
{
    var directories = Directory.GetDirectories(path);
    
    foreach (var directory in directories)
    {
        List<Group> groupsChilds = new List<Group>();
        var directoryName = Path.GetDirectoryName(directory);
        if (!string.IsNullOrWhiteSpace(directory))
        {
            Group group = new Group();
            FindDirectories(directory);

            var childs = Directory.GetDirectories(directory);
            foreach (var child in childs)
            {
                groupsChilds.Add(new Group()
                {
                    TotalPath = child,
                    Name = new DirectoryInfo(child).Name
            });
            }
            group.Children = groupsChilds;
            group.TotalPath = directory;
            group.Name = new DirectoryInfo(directory).Name;
            groups.Add(group);
        }
    }
    return "";
}




foreach (var item in groups)
{
    Console.WriteLine(">>Total Path: {0}",item.TotalPath);
    Console.WriteLine();
    
    foreach (var childs in item.Children)
    {
        Console.WriteLine(">>>>> Child of {0}: {1} ",item.Name, childs.Name);
    }
    Console.WriteLine();
}

//string downloadFolder = "F:\\BenR\\LogicTesting\\Download\\";
//
//string mainPath = "F:\\BenR\\LogicTesting\\Gradient-Abrechnung 1\\06_EBM2000+\\# Strecke ASV\\ASV Leistungsstammdaten\\2022\\2022_4\\Stand_18.10.2022";
//
//
//Test t = new Test();
//
//await t.CopyZipFilesAsync(downloadFolder,mainPath);
//
//await t.UnzipFilesAsync(mainPath);
//
//await t.MappingFilesAsync(mainPath);