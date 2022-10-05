using NUnit.Framework;
using PageObjectModel;

namespace Tests
{
    public class Program : BaseTest
    {
        [Test]
        public void PageTests()
        {
            InitPage init = new InitPage(driver);
            init.ClickSignIn();
            SigninPage login = new SigninPage(driver);
            Thread.Sleep(500);
            login.InsertEmailInInput("user@gmail.com");
            login.InsertPasswordlInInput("123456");
            login.ClickSignInButton();
            Thread.Sleep(1000);
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
