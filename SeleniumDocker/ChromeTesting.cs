using NUnit.Framework;

namespace SeleniumDocker
{
    [TestFixture]
    [Parallelizable]
    public class ChromeTesting : Hooks
    {
        public ChromeTesting() : base(BrowserType.Chrome)
        {
        }

        [Test]
        public void ChromeTest()
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

            Assert.IsFalse(Driver.PageSource.Contains("Houss2222em Dellai"));
        }
    }
}
