
using NUnit.Framework;
using SzoftvertesztBeadando.pages;
using System.Linq;

namespace SzoftvertesztBeadando.tests
{
    [TestFixture]
    public class GamePlatformsPageTests : BaseTests
    {
        [SetUp]
        public void LoginAndGoToGamePlatforms()
        {
            loginPage.GoTo();
            loginPage.Login("admin", "1234");
            mainPage.GoToPlatformGames();
        }

        [Test]
        public void AllProducts_AreVisibleByDefault()
        {
            var games = gamePlatformsPage.GetVisibleProducts();
            Assert.That(games.Count, Is.GreaterThan(0));
        }

        [Test]
        public void FilterByXbox_ShowsOnlyXboxGames()
        {
            gamePlatformsPage.SelectPlatform("xbox");
            var games = gamePlatformsPage.GetVisibleProducts();
            Assert.That(games.All(p => p.Text.Contains("Halo") || p.Text.Contains("Forza") || p.Text.Contains("Hi-Fi") || p.Text.Contains("BreakDown") || p.Text.Contains("Brute Force") || p.Text.Contains("Blood Wake") || p.Text.Contains("Rocket League")));
        }

        [Test]
        public void FilterBySwitch_ShowsOnlySwitchGames()
        {
            gamePlatformsPage.SelectPlatform("switch");
            var games = gamePlatformsPage.GetVisibleProducts();
            Assert.That(games.All(p => p.Text.Contains("Mario Kart") || p.Text.Contains("Zelda") || p.Text.Contains("Rocket League")));
        }

        [Test]
        public void FilterByPlayStation_ShowsOnlyPlayStationhGames()
        {
            gamePlatformsPage.SelectPlatform("playstation");
            var games = gamePlatformsPage.GetVisibleProducts();
            Assert.That(games.All(p => p.Text.Contains("Rift") || p.Text.Contains("Bloodborne") || p.Text.Contains("Helldivers") || p.Text.Contains("Gran Turismo 4") || p.Text.Contains("Shadow of the Colossus") || p.Text.Contains("Crash Bandicoot") || p.Text.Contains("Rocket League")));
        }

        [Test]
        public void FilterByPC_ShowsOnlyPCGames()
        {
            gamePlatformsPage.SelectPlatform("pc");
            var games = gamePlatformsPage.GetVisibleProducts();
            Assert.That(games.All(p => p.Text.Contains("Halo") || p.Text.Contains("Forza") || p.Text.Contains("Rush") || p.Text.Contains("Rift") || p.Text.Contains("Bloodborne") || p.Text.Contains("Crash") || p.Text.Contains("Rocket League") ||p.Text.Contains("Counter-Strike") || p.Text.Contains("Helldivers")));
        }

        [Test]
        public void FilterByPanasonicQ_ShowsOnlyPanasonicQGames()
        {
            gamePlatformsPage.SelectPlatform("panasonic-q");
            var games = gamePlatformsPage.GetVisibleProducts();
            Assert.That(games.All(p => p.Text.Contains("Power")));
        }

        [Test]
        public void FilterByGizmondo_ShowsOnlyGizmondoGames()
        {
            gamePlatformsPage.SelectPlatform("gizmondo");
            var games = gamePlatformsPage.GetVisibleProducts();
            Assert.That(games.All(p => p.Text.Contains("Interstellar")));
        }

        [Test]
        public void FilterByVectrex_ShowsOnlyVectrexGames()
        {
            gamePlatformsPage.SelectPlatform("vectrex");
            var games = gamePlatformsPage.GetVisibleProducts();
            Assert.That(games.All(p => p.Text.Contains("Coaster")));
        }

        [Test]
        public void GamePlatforms_BackToMain_NavigatesToMainPage()
        {
            gamePlatformsPage.GoBackToMain();
            Assert.That(driver.Url, Does.Contain("main_page.html"));
        }

    }
}
