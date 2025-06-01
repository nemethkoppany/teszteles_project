
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
        public void PlatformButton_NavigatesToPlatformGames()
        {
            mainPage.GoToPlatformGames();
            Assert.That(driver.Url, Does.Contain("platform_games.html"));
        }

        [Test]
        public void GameForYouButton_NavigatesToGamesForYou()
        {
            mainPage.GoToGameForYou();
            Assert.That(driver.Url, Does.Contain("gameForYou.html"));
        }

        [Test]
        public void LogoutButton_NavigatesToLogin()
        {
            mainPage.Logout();
            Assert.That(driver.Url, Does.Contain("login.html"));
        }

        [Test]
        public void DetailsButton_TogglesDetails_ForETS()
        {
            Assert.That(mainPage.IsDetailsHidden(0), Is.True);

            mainPage.ClickDetailsButton(0);
            Assert.That(mainPage.IsDetailsVisible(0), Is.True);

            mainPage.ClickDetailsButton(0);
            Assert.That(mainPage.IsDetailsHidden(0), Is.True);
        }

        [Test]
        public void DetailsButton_TogglesDetails_ForTitanfall()
        {
            Assert.That(mainPage.IsDetailsHidden(1), Is.True);

            mainPage.ClickDetailsButton(1);
            Assert.That(mainPage.IsDetailsVisible(1), Is.True);

            mainPage.ClickDetailsButton(1);
            Assert.That(mainPage.IsDetailsHidden(1), Is.True);
        }

        [Test]
        public void DetailsButton_TogglesDetails_ForHellDivers()
        {
            Assert.That(mainPage.IsDetailsHidden(2), Is.True);

            mainPage.ClickDetailsButton(2);
            Assert.That(mainPage.IsDetailsVisible(2), Is.True);

            mainPage.ClickDetailsButton(2);
            Assert.That(mainPage.IsDetailsHidden(2), Is.True);
        }
    }
}
