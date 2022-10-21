using Console_Spielerei;
using System.IO;

Group g = new Group();

List<string> list = new List<string>();

// Start Directory
//FindDirectories("D:\\Eigene Projekte");

string root = "C:\\Users\\Benex\\Desktop\\Projects";

var directories = Directory.GetDirectories(root,"",SearchOption.TopDirectoryOnly);

Print(directories);



void Print(string[] paths)
{
    Group g = new Group();
    if (paths != null)
    {
        foreach (var path in paths)
        {
            list.Add(path);
            Console.WriteLine(path);
            var ps = GetDirectories(path);
            Print(ps);
        }
    }
}
 

string[] GetDirectories(string path)
{
    return Directory.GetDirectories(path, "", SearchOption.TopDirectoryOnly);
}


Group FindGroup(string path)
{
    var group = new Group();


    return group;
}


//Group FindDirectory(string path)
//{
//    var group = new Group();
//
//    List<Group> groups = new List<Group>();
//
//    var name = new DirectoryInfo(path).Name;
//
//    var folder = path.Substring(0, (path.Length - name.Length));
//
//    var directories = Directory.GetDirectories(folder);
//
//    foreach (var d in directories)
//    {
//        groups.Add(new Group()
//        {
//            Name = new DirectoryInfo(d).Name,
//            TotalPath = d
//        });
//    }
//
//    group.Children = groups;
//    group.Name = name;
//    group.TotalPath = path;
//
//    return group;
//}

Console.WriteLine();
//string FindDirectories(string path)
//{
//    var directories = Directory.GetDirectories(path);
//    
//    foreach (var directory in directories)
//    {
//        List<Group> groupsChilds = new List<Group>();
//        var directoryName = Path.GetDirectoryName(directory);
//        if (!string.IsNullOrWhiteSpace(directory))
//        {
//            Group group = new Group();
//            FindDirectories(directory);
//
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
//    
//    foreach (var childs in item.Children)
//    {
//        Console.WriteLine(">>>>> Child of {0}: {1} ",item.Name, childs.Name);
//    }
//    Console.WriteLine();
//}

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