using OpenQA.Selenium;

namespace PageObjectModel
{
    public class InitPage : BasePage
    {
        public InitPage(IWebDriver driver) : base(driver)
        {
                
        }

        private IWebElement buttonSignIn => driver.FindElement(By.ClassName("login"));

        public void ClickSignIn()
        {
            buttonSignIn.Click();
        }
    }
}
