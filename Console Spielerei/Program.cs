using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using HtmlAgilityPack;
using Console_Spielerei;
using System.Net;

string url = "https://www.crunchyroll.com/de/series/G1XHJVEZ1/243-seiin-high-school-boys-volleyball-team";

List<string> urls = new List<string>();

//string urlList = "https://www.crunchyroll.com/de/videos/alphabetical?group=all";



//WebDriver driver = new FirefoxDriver();

//driver.Navigate().GoToUrl(url);



// Finden aller URLs
//await Task.Delay(3000);

//for (int i = 0; i < 1700; i+=10)
//{
//    var page = driver.PageSource;
//    // Bekomme die PageSource und suche nach Elementen unter X

//    var doc = new HtmlDocument();
//    doc.LoadHtml(page);

//    var main = FindNodesByDocument(doc, "div", "class", "ReactVirtualized__Grid__innerScrollContainer").Result.FirstOrDefault();
//    // Finden der Liste und speichern der Elemente
//    var list = FindNodesByNode(main,"a","class", "horizontal-card__link--fkuce").Result;

//    foreach (var item in list)
//    {
//        var newurl = item.OuterHtml.Split('"')[7];

//        if(!urls.Contains("https://www.crunchyroll.com" + newurl))
//        {
//            urls.Add("https://www.crunchyroll.com" + newurl);
//        }
//    }

//    Console.WriteLine(i);
//    driver.ExecuteScript($"window.scrollBy(0, {i});");
//    await Task.Delay(500);
//}


WebDriver driver = new FirefoxDriver();

driver.Navigate().GoToUrl(url);


//await Task.Delay(1000);
//
//driver.FindElement(By.ClassName("evidon-banner-acceptbutton")).Click();

//await Task.Delay(2000);

driver.Navigate().GoToUrl(url);




var page = driver.PageSource;


var doc = new HtmlDocument();
doc.LoadHtml(page);

var urlSplit = url.Split('/');

var id = urlSplit[5];

var image = FindNodesByDocument(doc, "img", "alt", "Serien-Hintergrund").Result.FirstOrDefault().OuterHtml.Split('"');


// Main
var main = FindNodesByDocument(doc, "div", "class", "erc-series-hero").Result.FirstOrDefault();

var title = FindNodesByNode(main, "div", "class", "hero-heading-line").Result.FirstOrDefault().InnerText;

var description = FindNodesByNode(main, "p", "class", "expandable-section__text").Result.FirstOrDefault();

var genres = FindNodesByNode(main, "div", "class", "genre-badge").Result;

var rating = FindNodesByNode(main, "span", "class", "star-rating-average-data__label").Result.FirstOrDefault().InnerText.Substring(0,3);

var episodes = FindNodesByNode(main, "div", "class", "meta-tags").Result.FirstOrDefault().InnerText.Split(" ")[0];

foreach (var g in genres)
{
    Console.WriteLine(g.InnerText);
}





Console.WriteLine();
driver.Quit();



async Task<List<HtmlNode>> FindNodesByNode(HtmlNode node, string a, string b, string c)
{
    return node.Descendants(a).Where(node => node.GetAttributeValue(b, "").Contains(c)).ToList();
}

async Task<List<HtmlNode>> FindNodesByNodeEqual(HtmlNode node, string a, string b, string c)
{
    return node.Descendants(a).Where(node => node.GetAttributeValue(b, "").Equals(c)).ToList();
}

async Task<List<HtmlNode>> FindNodesByDocument(HtmlDocument document, string a, string b, string c)
{
    return document.DocumentNode.Descendants(a).Where(node => node.GetAttributeValue(b, "").Contains(c)).ToList();
}