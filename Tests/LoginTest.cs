using NUnit.Framework;
using PageObjectModel;

namespace Tests
{
    public class LoginTest : BaseTest
    {
        [Test]//attribute
        public void NegativeLogin()//test
        {
            InitPage init = new InitPage(driver);//method body
            init.ClickSignIn();
            LoginPage login = new LoginPage(driver);
            Thread.Sleep(500);
            login.InsertEmailInInput("user@gmail.com");
            login.InsertPasswordlInInput("123456");
            login.ClickSignInButton();
            Thread.Sleep(1000);

            /*string actualErrorAuthFaildText = login.GetErrorMessage();
            string expectedErrorAuthFaildText = "Authentication failed.";
            Assert.AreEqual(expectedErrorAuthFaildText, actualErrorAuthFaildText, $"{expectedErrorAuthFaildText} is not equalto {actualErrorAuthFaildText}");*/
        
        }
    }
}
