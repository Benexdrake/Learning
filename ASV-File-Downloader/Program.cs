using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

string url = "https://institut-ba.de/service/asvabrechnung/asvabrechnungcsv.html";

WebDriver driver = new FirefoxDriver();

driver.Navigate().GoToUrl(url);

driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/div/div/div/div[2]/div/form/p[3]/input")).Click();

await Task.Delay(2000);

driver.FindElement(By.XPath("/html/body/div[2]/div/div[3]/div/div/div/div[2]/div/form/p[4]/input")).Click();