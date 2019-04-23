using System.Threading;
using Automation.Framework.Selenium;
using Automation.Framework.Utilities;
using OpenQA.Selenium;

namespace Automation.Framework.Pages
{
    public class GoogleHomePage
    {
        private readonly Driver _driver;
        private readonly WaitFor _waitFor;

        public GoogleHomePage(Driver driver)
        {
            _driver = driver;
            _waitFor = new WaitFor(driver);
        }

        public void SelectGoogleApps()
        {
            _waitFor.GoogleHomePageToLoad();
            _driver.Browser.FindElement(By.Id("gbwa")).Click();
            _waitFor.GoogleAppDropdownToLoad();
        }

        public void GoToSearchViaGoogleApps()
        {
            _waitFor.GoogleHomePageToLoad();
            SelectGoogleApps();
            _driver.Browser.FindElement(By.Id("gb1")).Click();
        }

        public void GoToMapViaGoogleApps()
        {
            _waitFor.GoogleHomePageToLoad();
            SelectGoogleApps();
            _driver.Browser.FindElement(By.Id("gb8")).Click();
        }

        public void GoToYoutubeViaGoogleApps()
        {
            _waitFor.GoogleHomePageToLoad();
            SelectGoogleApps();
            _driver.Browser.FindElement(By.Id("gb36")).Click();
        }

        public void GoToPlayViaGoogleApps()
        {
            _waitFor.GoogleHomePageToLoad();
            SelectGoogleApps();
            _driver.Browser.FindElement(By.Id("gb78")).Click();
        }

        public void GoToNewsViaGoogleApps()
        {
            _waitFor.GoogleHomePageToLoad();
            SelectGoogleApps();
            _driver.Browser.FindElement(By.Id("gb5")).Click();
        }

        public void GoToGmailViaGoogleApps()
        {
            _waitFor.GoogleHomePageToLoad();
            SelectGoogleApps();
            _driver.Browser.FindElement(By.Id("gb23")).Click();
        }

        public void GoToContactsViaGoogleApps()
        {
            _waitFor.GoogleHomePageToLoad();
            SelectGoogleApps();
            _driver.Browser.FindElement(By.Id("gb53")).Click();
        }

        public void GoToDriveViaGoogleApps()
        {
            _waitFor.GoogleHomePageToLoad();
            SelectGoogleApps();
            _driver.Browser.FindElement(By.Id("gb49")).Click();
        }

        public void GoToCalendarViaGoogleApps()
        {
            _waitFor.GoogleHomePageToLoad();
            SelectGoogleApps();
            _driver.Browser.FindElement(By.Id("gb24")).Click();
        }

        public void GoToGooglePlusViaGoogleApps()
        {
            _waitFor.GoogleHomePageToLoad();
            SelectGoogleApps();
            _driver.Browser.FindElement(By.Id("gb119")).Click();
        }

        public void GoToTranslateViaGoogleApps()
        {
            _waitFor.GoogleHomePageToLoad();
            SelectGoogleApps();
            _driver.Browser.FindElement(By.Id("gb51")).Click();
        }

        public void GoToPhotosViaGoogleApps()
        {
            _waitFor.GoogleHomePageToLoad();
            SelectGoogleApps();
            _driver.Browser.FindElement(By.Id("gb31")).Click();
        }
    }
}