using System;
using System.Collections.Generic;
using System.Text;
using Automation.Framework.Selenium;
using Automation.Framework.Utilities;
using OpenQA.Selenium;

namespace Automation.Framework.Pages
{
    public class GoogleTranslatePage
    {
        private readonly Driver _driver;
        private readonly WaitFor _waitFor;

        public GoogleTranslatePage(Driver driver)
        {
            _driver = driver;
            _waitFor = new WaitFor(driver);
        }

        public void EnterSourceText(string enteredText)
        {
            _driver.Browser.FindElement(By.Id("source")).SendKeys(enteredText);
        }

        public string GetTranslatedText()
        {
            _waitFor.ElementToAppearByClass("span", "tlid-translation translation");
            return _driver.Browser.FindElement(By.XPath("//span[@class='tlid-translation translation']")).Text;
        }
    }
}
