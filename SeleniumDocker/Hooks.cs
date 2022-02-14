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

    public class SelenoidOptions
    {
        public bool enableVnc = true;
        public bool enableVideo = true;
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
            // this part for Selenoid
            if (browserType == BrowserType.Chrome)
            {
                var selenoidOptions = new SelenoidOptions();
                var options = new ChromeOptions();
                options.AddAdditionalOption("selenoid:options", selenoidOptions);
                Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options);
            }
            else if (browserType == BrowserType.Firefox)
            {
                var options2 = new FirefoxOptions();
                options2.AddAdditionalOption("selenoid:options", new { enableVNC = true });
                Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options2);
            }

            // this part for selenium grid
            //if (browserType == BrowserType.Chrome)
            //{
            //    var options = new ChromeOptions();
            //    Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options);
            //}
            //else
            //{
            //    var options = new FirefoxOptions();
            //    Driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), options);
            //}
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
