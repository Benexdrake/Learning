namespace Discord_Bot
{
    public class Program
    {
        public static void Main()
        {
            Bot bot = new Bot();
            bot.Connect().GetAwaiter().GetResult();
        }
    }
}