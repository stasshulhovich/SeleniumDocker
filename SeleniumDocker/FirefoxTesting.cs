using NUnit.Framework;

namespace SeleniumDocker
{
    [TestFixture]
    [Parallelizable]
    public class FirefoxTesting : Hooks
    {
        public FirefoxTesting() : base(BrowserType.Firefox)
        {
        }

        [Test]
        public void FireFoxTest()
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("https://www.youtube.com/houssemdellai");
            Driver.Navigate().GoToUrl("https://www.rambler.ru");
            Driver.Navigate().GoToUrl("https://www.google.com");
            Driver.Navigate().GoToUrl("https://www.youtube.com/houssemdellai");
            Driver.Navigate().GoToUrl("https://www.youtube.com/houssemdellai");
            Driver.Navigate().GoToUrl("https://www.rambler.ru");
            Driver.Navigate().GoToUrl("https://www.google.com");
            Driver.Navigate().GoToUrl("https://www.youtube.com/houssemdellai");
            Driver.Navigate().GoToUrl("https://www.youtube.com/houssemdellai");
            Driver.Navigate().GoToUrl("https://www.rambler.ru");
            Driver.Navigate().GoToUrl("https://www.google.com");
            Driver.Navigate().GoToUrl("https://www.youtube.com/houssemdellai");
            Driver.Navigate().GoToUrl("https://www.youtube.com/houssemdellai");
            Driver.Navigate().GoToUrl("https://www.rambler.ru");
            Driver.Navigate().GoToUrl("https://www.google.com");
            Driver.Navigate().GoToUrl("https://www.youtube.com/houssemdellai");
            Driver.Navigate().GoToUrl("https://www.youtube.com/houssemdellai");
            Driver.Navigate().GoToUrl("https://www.rambler.ru");
            Driver.Navigate().GoToUrl("https://www.google.com");
            Driver.Navigate().GoToUrl("https://www.youtube.com/houssemdellai");

            Assert.IsTrue(Driver.PageSource.Contains("Houssem Dellai"));
        }
    }
}
