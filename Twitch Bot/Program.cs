using TwitchLib;

namespace Twitch_Bot
{
    public class program
    {
        
        public static void Main()
        {
            Bot bot = new Bot();
            bot.Connect();

            Console.ReadLine();

            bot.Disconnect();

            
        }
    }
}