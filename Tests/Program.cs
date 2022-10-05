using NUnit.Framework;
using PageObjectModel;

namespace Tests
{
    public class Program : BaseTest
    {
        [Test]
        public void PageTests()
        {
            var initPage = new InitPage(driver);
            initPage.ClickSignIn();

            var loginPage = new SigninPage(driver);
            Thread.Sleep(500);

            loginPage.InsertEmailInInput("user@gmail.com");
            loginPage.InsertPasswordlInInput("123456");
            loginPage.ClickSignInButton();
            Thread.Sleep(1000);

            var actualParagraphCreateAccount = loginPage.CheckParagraphCreateAccountText();
            var expectedParagraphCreateAccount = "Please enter your email address to create an account.";
            Assert.AreEqual(expectedParagraphCreateAccount, actualParagraphCreateAccount);
            Console.WriteLine("expected = \"{0}\"\n  actual = \"{1}\"", expectedParagraphCreateAccount, actualParagraphCreateAccount);

            var actualHeaderRegistredAccount = loginPage.CheckHeaderRegistrationText();
            var expectedHeaderRegistredAccount = "ALREADY REGISTERED?";
            Assert.AreEqual(expectedHeaderRegistredAccount, actualHeaderRegistredAccount);
            Console.WriteLine("expected = \"{0}\"\n  actual = \"{1}\"", expectedHeaderRegistredAccount, actualHeaderRegistredAccount);

            var actualButtonCreateAccount = loginPage.CheckButtonCreateAccountText();
            var expectedButtonCreateAccount = "Create an account";
            Assert.AreEqual(expectedButtonCreateAccount, actualButtonCreateAccount);
            Console.WriteLine("expected = \"{0}\"\n  actual = \"{1}\"", expectedButtonCreateAccount, actualButtonCreateAccount);
        }
    }
}
