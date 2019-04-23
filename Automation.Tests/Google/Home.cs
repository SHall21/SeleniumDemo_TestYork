using Automation.Framework.Pages;
using Automation.Tests.Common;
using FluentAssertions;
using NUnit.Framework;

namespace Automation.Tests.Google
{
    public class Home : BaseUI
    {
        private GoogleHomePage _googleHomePage;

        [SetUp]
        public override void SetUp()
        {
            base.SetUp();

            _googleHomePage = new GoogleHomePage(Driver);

            Driver.BrowseTo("https://www.google.co.uk/");
        }

        //[SetUp]
        //public void SetUp()
        //{
        //    Driver.BrowseTo("https://www.google.co.uk/");
        //}

        [Test]
        public void SelectGoogleApps()
        {
            _googleHomePage.SelectGoogleApps();
        }

        [Test]
        public void NavigateToCalendarApp()
        {
            _googleHomePage.GoToCalendarViaGoogleApps();
            Driver.Title.Should().Contain("Calendar");
        }

        [Test]
        public void NavigateToContactsApp()
        {
            _googleHomePage.GoToContactsViaGoogleApps();
            Driver.Title.Should().Contain("Sign in - Google Accounts");
        }

        [Test]
        public void NavigateToDriveApp()
        {
            _googleHomePage.GoToDriveViaGoogleApps();
            Driver.Title.Should().Contain("Drive");
        }

        [Test]
        public void NavigateToGmailApp()
        {
            _googleHomePage.GoToGmailViaGoogleApps();
            Driver.Title.Should().Contain("Gmail");
        }

        [Test]
        public void NavigateToGooglePlusApp()
        {
            _googleHomePage.GoToGooglePlusViaGoogleApps();
            Driver.Title.Should().Contain("+");
        }

        [Test]
        public void NavigateToMapApp()
        {
            _googleHomePage.GoToMapViaGoogleApps();
            Driver.Title.Should().Contain("Maps");
        }

        [Test]
        public void NavigateToNewsApp()
        {
            _googleHomePage.GoToNewsViaGoogleApps();
            Driver.Title.Should().Contain("News");
        }

        [Test]
        public void NavigateToPhotosApp()
        {
            _googleHomePage.GoToPhotosViaGoogleApps();
            Driver.Title.Should().Contain("Photos");
        }

        [Test]
        public void NavigateToPlayApp()
        {
            _googleHomePage.GoToPlayViaGoogleApps();
            Driver.Title.Should().Contain("Play");
        }

        [Test]
        public void NavigateToSearchApp()
        {
            _googleHomePage.GoToSearchViaGoogleApps();
            Driver.Title.Should().Contain("Google");
        }

        [Test]
        public void NavigateToTranslateApp()
        {
            _googleHomePage.GoToTranslateViaGoogleApps();
            Driver.Title.Should().Contain("Translate");
        }
        [Test]
        public void NavigateToYoutubeApp()
        {
            _googleHomePage.GoToYoutubeViaGoogleApps();
            Driver.Title.Should().Contain("YouTbe");
        }
    }
}