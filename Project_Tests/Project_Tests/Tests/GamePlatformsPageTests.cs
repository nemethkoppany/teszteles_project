
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
            mainPage.GoToProducts();
        }

        [Test]
        public void AllProducts_AreVisibleByDefault()
        {
            var products = gamePlatformsPage.GetVisibleProducts();
            Assert.That(products.Count, Is.GreaterThan(0));
        }

        [Test]
        public void FilterByXbox_ShowsOnlyXboxGames()
        {
            gamePlatformsPage.SelectPlatform("xbox");
            var products = gamePlatformsPage.GetVisibleProducts();
            Assert.That(products.All(p => p.Text.Contains("Halo") || p.Text.Contains("Forza") || p.Text.Contains("Hi-Fi") || p.Text.Contains("BreakDown") || p.Text.Contains("Brute Force") || p.Text.Contains("Blood Wake") || p.Text.Contains("Rocket league")));
        }

        [Test]
        public void FilterBySwitch_ShowsOnlySwitchGames()
        {
            gamePlatformsPage.SelectPlatform("switch");
            var products = gamePlatformsPage.GetVisibleProducts();
            Assert.That(products.All(p => p.Text.Contains("Mario Kart") || p.Text.Contains("Zelda") || p.Text.Contains("Rocket league")));
        }
    }
}
