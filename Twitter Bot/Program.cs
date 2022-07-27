

using System.Diagnostics;
using Tweetinvi;

namespace Twitter_Bot;

public static class Program
{
    public static async Task Main()
    {
        //Bot bot = new Bot();
        //bot.Start();

        // ---------------------------------------------------
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Twitter-Keys.JSON";
        Keys key = new Keys(path);
        
        var userClient = new TwitterClient(key.APIKey,key.APIKeySecret,key.AccessToken, key.AccessTokenSecret);
        //
        //var user = await userClient.Users.GetAuthenticatedUserAsync();
        //Console.WriteLine("Username: " + user);
        var userResponse = await userClient.UsersV2.GetUserByNameAsync("Benexdrake");
        var user = userResponse.User;
        Console.WriteLine(user.Id);
        Console.WriteLine(user.Name);


        var tweetResponse = await userClient.TweetsV2.GetTweetsAsync("germany");
        var tweet = tweetResponse.Tweets;
        foreach (var item in tweet)
        {
            Console.WriteLine(item.Text);
        }

        
    }
}