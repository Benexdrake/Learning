using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections.ObjectModel;

namespace CrunchyrollV2
{
    public class API
    {
        IWebDriver driver = new ChromeDriver();

        public async Task Start()
        {
            driver.Navigate().GoToUrl("");


            


        }
        
    }
}
