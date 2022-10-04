using OpenQA.Selenium;

namespace PageObjectModel
{
    public class BasePage
    {
        protected static IWebDriver driver;
        public BasePage(IWebDriver webDriver)//constructor send driver in this class
        {
            driver = webDriver;
        }
    }
}