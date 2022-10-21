using Console_Spielerei;

Group group = new();

string root = "D:\\Eigene Projekte";
var directories = GetDirectories(root);

group = PrintGroup(directories);

Console.WriteLine();


//Print(directories);
// Old find Directions
void Print(string[] dirs)
{
    if(dirs != null)
    {
        foreach (var path in dirs)
        {
            //list.Add(path);
            Console.WriteLine(path);
            var ps = GetDirectories(path);
            Print(ps);
        }
    }
}

// Find Directions and saved as Group, from Start to Childs childs childs.
Group PrintGroup(string[] dirs)
{
    if (dirs != null)
    {
        Group g = new Group();
        foreach (var path in dirs)
        {
            var ps = GetDirectories(path);
            var group = PrintGroup(ps);
            if (group != null)
                g.Children.Add(group);
            g.TotalPath = path;
            g.Name = new DirectoryInfo(path).Name;
        }
        return g;
    }
    return null;
}

string[] GetDirectories(string path)
{
    return Directory.GetDirectories(path, "", SearchOption.TopDirectoryOnly);
}





//List<Group> groups = new List<Group>();

//// Start Directory
//FindDirectories("D:\\Eigene Projekte");

//string FindDirectories(string path)
//{
//    var directories = Directory.GetDirectories(path);
    
//    foreach (var directory in directories)
//    {
//        List<Group> groupsChilds = new List<Group>();
//        var directoryName = Path.GetDirectoryName(directory);
//        if (!string.IsNullOrWhiteSpace(directory))
//        {
//            Group group = new Group();
//            FindDirectories(directory);

//            var childs = Directory.GetDirectories(directory);
//            foreach (var child in childs)
//            {
//                groupsChilds.Add(new Group()
//                {
//                    TotalPath = child,
//                    Name = new DirectoryInfo(child).Name
//            });
//            }
//            group.Children = groupsChilds;
//            group.TotalPath = directory;
//            group.Name = new DirectoryInfo(directory).Name;
//            groups.Add(group);
//        }
//    }
//    return "";
//}




//foreach (var item in groups)
//{
//    Console.WriteLine(">>Total Path: {0}",item.TotalPath);
//    Console.WriteLine();
    
//    foreach (var childs in item.Children)
//    {
//        Console.WriteLine(">>>>> Child of {0}: {1} ",item.Name, childs.Name);
//    }
//    Console.WriteLine();
//}

////string downloadFolder = "F:\\BenR\\LogicTesting\\Download\\";
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