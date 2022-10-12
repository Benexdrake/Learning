namespace Console_Spielerei
{
    class Program
    {
        public static async Task Main()
        {
            List<string> list = new List<string>();
            Test t = new();

            string mainPath = "C:\\Users\\RichterB\\Desktop\\Ordner";
            t.directoriesPathList.Add(mainPath);

            t.FindDirectories(mainPath);

            foreach (var item in t.directoriesPathList)
            {
                Console.WriteLine(item);
                var test = t.ReadFile(item).ToList();
                
                foreach (var t1 in test)
                {
                    list.Add(t1);
                }
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

           await t.SaveFile(list.ToArray(), "ARZTGRUPPEN", "C:\\Users\\RichterB\\Desktop\\OutPut");
           await t.SaveFile(list.ToArray(), "ABSCHNITT", "C:\\Users\\RichterB\\Desktop\\OutPut");

        }
    }
}