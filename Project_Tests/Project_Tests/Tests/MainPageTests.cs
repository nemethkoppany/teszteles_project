
using NUnit.Framework;
using SzoftvertesztBeadando.pages;

namespace SzoftvertesztBeadando.tests
{
    [TestFixture]
    public class MainPageTests : BaseTests
    {
        [SetUp]
        public void LoginFirst()
        {
            loginPage.GoTo();
            loginPage.Login("admin", "1234");
        }

        [Test]
        public void PlatformButton_NavigatesToProducts()
        {
            mainPage.GoToProducts();
            Assert.That(driver.Url, Does.Contain("platform_games.html"));
        }

        [Test]
        public void GameForYouButton_NavigatesToCart()
        {
            mainPage.GoToCart();
            Assert.That(driver.Url, Does.Contain("gameForYou.html"));
        }

        [Test]
        public void LogoutButton_NavigatesToLogin()
        {
            mainPage.Logout();
            Assert.That(driver.Url, Does.Contain("login.html"));
        }
    }
}
