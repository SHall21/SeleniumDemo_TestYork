using OpenQA.Selenium.Chrome;

namespace Automation.Framework.Selenium
{
    public class Driver
    {
        public ChromeDriver Browser;
        public string Title => Browser.Title;

        public void Initialise()
        {
            var options = new ChromeOptions();
            options.AddArgument("--window-size=768x1368");
            Browser = new ChromeDriver(".", options);
        }

        public void BrowseTo(string url)
        {
            Browser.Navigate().GoToUrl(url);
        }

        public void Dispose()
        {
            Browser?.Quit();
            Browser = null;
        }
    }
}
