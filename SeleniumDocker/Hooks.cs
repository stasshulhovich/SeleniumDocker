using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;

namespace SeleniumDocker
{
    public enum BrowserType
    {
        Chrome,
        Firefox,
        IE
    }

    [TestFixture]
    public class Hooks : Base
    {
        private BrowserType _browserType;

        public Hooks(BrowserType browserType)
        {
            _browserType = browserType;
        }

        [SetUp]
        public void Initialise()
        {
            ChooseWebDriver(_browserType);
        }

        
        public void ChooseWebDriver(BrowserType browserType)
        {
            if (browserType == BrowserType.Chrome)
            {
                var options = new ChromeOptions();
                Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options);
            }
            else
            {
                var options = new FirefoxOptions();
                Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options);
            }
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
