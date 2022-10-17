namespace EntityFramework;

public class program
{
    static void Main(string[] args)
    {
        var db = new Data.AdventureWorksDbContext();

        var peoples = db.People;

        foreach (var people in peoples)
        {
            Console.WriteLine($"Name: {people.FirstName} {people.LastName}");
        }
    }
}