using Azure.Storage.Blobs;
using MySQL_API;
using System.Net;

namespace Console_Spielerei
{
    class Program
    {
        public static void Main()
        {
            MysqlDB db = new("root", "Dragoonstorm1983", "3306", "sakila", "localhost");

            var reader = db.Read("select * from actor;");


            foreach (var item in reader)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Ende");
            Console.ReadLine();
        }

        
    }
}