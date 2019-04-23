using Automation.Framework.Selenium;
using NUnit.Framework;

namespace Automation.Tests.Common
{
    [TestFixture]
    public class BaseUI
    {
        public Driver Driver;

        [SetUp]
        public virtual void SetUp()
        {
            Driver = new Driver();
            Driver.Initialise();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Dispose();
        }
    }
}