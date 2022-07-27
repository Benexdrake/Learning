using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;

namespace CrunchyrollV2
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            var start = driver.Manage().Network.StartMonitoring();
            driver.Navigate().GoToUrl("https://beta.crunchyroll.com/de/series/GQWH0MD5X");
            driver.Manage().Network.NetworkRequestSent += Network_NetworkRequestSent;

            

            driver.Manage().Network.NetworkResponseReceived += Network_NetworkResponseReceived;


            Console.ReadKey();
            //new API().Start();
        }

        private static void Network_NetworkRequestSent(object? sender, NetworkRequestSentEventArgs e)
        {
            Console.WriteLine("< " + e.RequestPostData);
        }

        private static void Network_NetworkResponseReceived(object? sender, NetworkResponseReceivedEventArgs e)
        {
            if(e.ResponseResourceType.Equals("Other"))
            {
                Console.WriteLine("> " + e.ResponseResourceType);
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine(e.RequestId);
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine(e.ResponseHeaders);
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine(e.ResponseBody);
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine(e.ResponseStatusCode);
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine(e.ResponseUrl);
                Console.WriteLine("-----------------------------------------");

                

            }
        }
    }
}