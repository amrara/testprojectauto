using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;

namespace ClassLibrary1
{
    [SetUpFixture]
    public class TestsSetupClass
    {
        protected IWebDriver driver;

        [OneTimeSetUp]
        public void GlobalSetup()
        {
            var capabilities = new DesiredCapabilities("chrome", string.Empty, new Platform(PlatformType.Any));
            driver = new RemoteWebDriver(new Uri("http://10.2.115.139:4445/wd/hub"), capabilities);
        }

        [OneTimeTearDown]
        public void GlobalTeardown()
        {
            driver.Quit();
        }
    }
}
