using Automation.Framework.Pages;
using Automation.Tests.Common;
using FluentAssertions;
using NUnit.Framework;

namespace Automation.Tests.Google
{
    public class Translate : BaseUI
    {
        private GoogleHomePage _googleHomePage;
        private GoogleTranslatePage _googleTranslatePage;

        [SetUp]
        public override void SetUp()
        {
            base.SetUp();

            _googleTranslatePage = new GoogleTranslatePage(Driver);
            _googleHomePage = new GoogleHomePage(Driver);

            Driver.BrowseTo("https://www.google.co.uk/");
            _googleHomePage.GoToTranslateViaGoogleApps();
        }

        //[SetUp]
        //public void SetUp()
        //{
        //    Driver.BrowseTo("https://www.google.co.uk/");
        //    _googleHomePage.GoToTranslateViaGoogleApps();
        //}

        [Test]
        public void TranslateGermanToEnglish()
        {
            _googleTranslatePage.EnterSourceText("Der Test ist ein Erfolg");
            _googleTranslatePage.GetTranslatedText().Should().Contain("The test is a success");
        }
    }
}
