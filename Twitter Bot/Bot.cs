using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Models;
using Tweetinvi.Parameters;

namespace Twitter_Bot
{
    public class Bot
    {
        
        TwitterClient UserClient;
        Keys key;
        public Bot()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Twitter-Keys.JSON";
            key = new Keys(path);
            UserClient = new TwitterClient(key.APIKey, key.APIKeySecret, key.AccessToken, key.AccessTokenSecret);

            
        }

        public async Task SendTweet(string _status)
        {
            await UserClient.Tweets.PublishTweetAsync(_status);
        }

        public async Task<ITweet[]> Search(string query)
        {
            try
            {
                //return await UserClient.Search.SearchTweetsAsync(query);
                return await UserClient.Search.SearchTweetsAsync(query);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task Start()
        {
            //SendTweet("Hello World");
            Console.WriteLine("Search for Data");
            var tweets = await Search("germany");
            foreach (var item in tweets)
            {
                Console.WriteLine(item);
            }
        }
    }
}
