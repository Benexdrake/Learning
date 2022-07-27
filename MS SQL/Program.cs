namespace MS_SQL
{
    class Program
    {
        public static void Main()
        {
            MSSQLDB ms = new MSSQLDB();

            ms.WritePersonDB($"  Insert into Sample.dbo.People values ('Test2', 'Test2', 'Test2', 'Test2'); ");

            foreach (var item in ms.LoadPersonDB())
            {
                Console.WriteLine(item.LoadPersonInfo());
                Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------");
            }
        }
    }
}