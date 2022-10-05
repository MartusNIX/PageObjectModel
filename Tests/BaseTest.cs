using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;//driver = accessible for methods, protected = accessible only for child class(test)

        [SetUp]
        public void SetUp() //method
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}