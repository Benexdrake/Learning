

namespace XUnitTest
{
    public class XUnitTest
    {
        [Fact]
        public void MySQLTest()
        {
            MysqlDB db = new("root", "Dragoonstorm1983", "3306", "sakila", "localhost");
            
            var reader = db.Read("select * from actor;");
            
            foreach (var item in reader)
            {
                Console.WriteLine(item);
            }
        }

        [Fact]
        public void CrunchyrollTest()
        {
            CR_API api = new(Browser.Firefox);
            api.GetAnimeByUrlAsync("https://www.crunchyroll.com/de/86-eighty-six");
        }
    }
}