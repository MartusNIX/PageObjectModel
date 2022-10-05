using NUnit.Framework;
using PageObjectModel;

namespace Tests
{
    public class Program : BaseTest
    {
        [Test]//attribute
        public void PageTests()//test
        {
            InitPage init = new InitPage(driver);//method body
            init.ClickSignIn();
            SigninPage login = new SigninPage(driver);
            Thread.Sleep(500);
            login.InsertEmailInInput("user@gmail.com");
            login.InsertPasswordlInInput("123456");
            login.ClickSignInButton();
            Thread.Sleep(1000);

            /*string actualErrorAuthFaildText = login.GetErrorMessage();
            string expectedErrorAuthFaildText = "Authentication failed.";
            Assert.AreEqual(expectedErrorAuthFaildText, actualErrorAuthFaildText, $"{expectedErrorAuthFaildText} is not equalto {actualErrorAuthFaildText}");*/

            string actualParagraphCreateAccount = login.CheckParagraphCreateAccountText();
            string expectedParagraphCreateAccount = "Please enter your email address to create an account.";
            Assert.AreEqual(expectedParagraphCreateAccount, actualParagraphCreateAccount);
            Console.WriteLine("expected = \"{0}\"\n  actual = \"{1}\"", expectedParagraphCreateAccount, actualParagraphCreateAccount);

            string actualHeaderRegistredAccount = login.CheckHeaderRegistrationText();
            string expectedHeaderRegistredAccount = "ALREADY REGISTERED?";
            Assert.AreEqual(expectedHeaderRegistredAccount, actualHeaderRegistredAccount);
            Console.WriteLine("expected = \"{0}\"\n  actual = \"{1}\"", expectedHeaderRegistredAccount, actualHeaderRegistredAccount);

            string actualButtonCreateAccount = login.CheckButtonCreateAccountText();
            string expectedButtonCreateAccount = "Create an account";
            Assert.AreEqual(expectedButtonCreateAccount, actualButtonCreateAccount);
            Console.WriteLine("expected = \"{0}\"\n  actual = \"{1}\"", expectedButtonCreateAccount, actualButtonCreateAccount);
        }
    }
}
