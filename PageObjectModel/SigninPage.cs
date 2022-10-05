using OpenQA.Selenium;

namespace PageObjectModel
{
    public class SigninPage : BasePage
    {
        public SigninPage(IWebDriver driver) : base(driver)
        {

        }

        private IWebElement headAuthentication => driver.FindElement(By.ClassName("page-heading"));

        private IWebElement headCreateAnAccount => driver.FindElement(By.CssSelector("#create-account_form > h3"));
        private IWebElement paragraphCreateAnAccount => driver.FindElement(By.CssSelector("#create-account_form > div > p"));
        private IWebElement labelEmailAddressCreation => driver.FindElement(By.CssSelector("#create-account_form > div > div.form-group > label"));
        private IWebElement inputCreateAccount => driver.FindElement(By.Id("email_create"));
        private IWebElement buttontCreateAccount => driver.FindElement(By.Id("SubmitCreate"));

        private IWebElement headRegistredAccount => driver.FindElement(By.CssSelector("#login_form > h3"));
        private IWebElement labelEmailAddressAuthorization => driver.FindElement(By.CssSelector("#login_form > div > div.form-group.form-error > label"));
        private IWebElement inputEmailAddressAuthorization => driver.FindElement(By.Id("email"));
        private IWebElement labelPasswordAuthorization => driver.FindElement(By.CssSelector("#login_form > div > div:nth-child(2) > label"));
        private IWebElement inputPasswordAuthorizationn => driver.FindElement(By.Id("passwd"));
        private IWebElement linkPasswordRecovery => driver.FindElement(By.LinkText("Forgot your password?"));
        private IWebElement buttonSignIn => driver.FindElement(By.Id("SubmitLogin"));
        /*private IWebElement errorAuthFailed => driver.FindElement(By.CssSelector("#center_column > div.alert.alert-danger > ol > li"));*/


        public void InsertEmailInInput(string text) => inputEmailAddressAuthorization.SendKeys(text);
        public void InsertPasswordlInInput(string text) => inputPasswordAuthorizationn.SendKeys(text);
        public void ClickSignInButton() => buttonSignIn.Click();
        //public string GetErrorMessage() => errorAuthFailed.Text;
        public string CheckParagraphCreateAccountText() => paragraphCreateAnAccount.Text;
        public string CheckHeaderRegistrationText() => headRegistredAccount.Text;
        public string CheckButtonCreateAccountText() => buttontCreateAccount.Text;
    }

}

