using Automation.Framework.Selenium;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace Automation.Framework.Utilities
{
    class WaitFor
    {
        private readonly Driver _driver;

        public WaitFor(Driver driver)
        {
            _driver = driver;
        }

        public void GoogleHomePageToLoad()
        {
            var wait = new WebDriverWait(_driver.Browser, TimeSpan.FromSeconds(6));
            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            wait.Until(driver => driver.FindElement(By.Id("gsr")).Displayed);
            wait.Until(driver => driver.Title == "Google");
        }

        public void GoogleAppDropdownToLoad()
        {
            Thread.Sleep(1000);
        }

        public void ElementToAppearByClass(string elementTag, string className)
        {
            var wait = new WebDriverWait(_driver.Browser, TimeSpan.FromSeconds(6));
            wait.IgnoreExceptionTypes(typeof(StaleElementReferenceException));
            wait.Until(driver => driver.FindElement(By.XPath($"//{elementTag}[@class='{className}']")).Displayed);
        }
    }
}