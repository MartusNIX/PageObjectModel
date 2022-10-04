using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
