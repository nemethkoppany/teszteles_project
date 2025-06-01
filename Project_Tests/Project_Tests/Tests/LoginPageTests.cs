
using NUnit.Framework;
using SzoftvertesztBeadando.pages;

namespace SzoftvertesztBeadando.tests
{
    [TestFixture]
    public class LoginPageTests : BaseTests
    {
        [Test]
        public void Login_WithValidCredentials_NavigatesToMain()
        {
            loginPage.GoTo();
            loginPage.Login("admin", "1234");
            Assert.That(driver.Url, Does.Contain("main_page.html"));
        }

        [Test]
        public void Login_WithInvalidUsername_ShowsError()
        {
            loginPage.GoTo();
            loginPage.Login("notuser", "1234");
            Assert.That(loginPage.GetErrorMessage(), Is.EqualTo("Nem létező felhasználó!"));
        }

        [Test]
        public void Login_WithInvalidPassword_ShowsError()
        {
            loginPage.GoTo();
            loginPage.Login("admin", "wrong");
            Assert.That(loginPage.GetErrorMessage(), Is.EqualTo("Helytelen jelszó!"));
        }

        [Test]
        public void Login_WithEmptyFields_ShowsError()
        {
            loginPage.GoTo();
            loginPage.Login("", "");
            Assert.That(loginPage.GetErrorMessage(), Is.EqualTo("Kérjük, adja meg a felhasználónevet és jelszót!"));
        }
    }
}
