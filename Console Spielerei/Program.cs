using MySQL_API;
namespace Console_Spielerei
{
    class Program
    {
        public static void Main()
        {
            List<string> list = new List<string>();

            var db = new MysqlDB("root", "InsertPassword", "3306", "sakila", "localhost");

            var IsLogin = db.LoginDB("select * from actor;");

            if(IsLogin)
            {
                db.Reader = db.Cmd.ExecuteReader();
                if(db.Reader.HasRows)
                {
                    while(db.Reader.Read())
                    {
                        list.Add(db.Reader.GetString("first_name"));
                    }
                }
                db.Con.Close();
            }
            else
            {
                Console.WriteLine(db.ErrorMessage);
            }

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}