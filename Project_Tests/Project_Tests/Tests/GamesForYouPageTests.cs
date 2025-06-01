
using NUnit.Framework;
using SzoftvertesztBeadando.pages;

namespace SzoftvertesztBeadando.tests
{
    [TestFixture]
    public class GamesForYouPageTests : BaseTests
    {
        [SetUp]
        public void LoginAndGoToGamesForYou()
        {
            loginPage.GoTo();
            loginPage.Login("admin", "1234");
            mainPage.GoToCart();
        }

        [Test]
        public void ValidYear_2000_RecommendationIsFortnite()
        {
            gamesForYouPage.EnterYear("2000");
            gamesForYouPage.RequestGame();
            Assert.That(gamesForYouPage.GetRecommendationText(), Is.EqualTo("Neked a Fortnite-ot ajánljuk!"));
        }

        [Test]
        public void ValidYear_1999_RecommendationIsPong()
        {
            gamesForYouPage.EnterYear("1999");
            gamesForYouPage.RequestGame();
            Assert.That(gamesForYouPage.GetRecommendationText(), Is.EqualTo("Neked a Pongot ajánljuk"));
        }

        [Test]
        public void EmptyYear_ShowsValidationMessage()
        {
            gamesForYouPage.EnterYear("");
            gamesForYouPage.RequestGame();
            Assert.That(gamesForYouPage.GetRecommendationText(), Is.EqualTo("Adj meg egy helyes évszámot!"));
        }

        [Test]
        public void BoundaryYear_1900_RecommendationIsPong()
        {
            gamesForYouPage.EnterYear("1900");
            gamesForYouPage.RequestGame();
            Assert.That(gamesForYouPage.GetRecommendationText(), Is.EqualTo("Neked a Pongot ajánljuk"));
        }

        [Test]
        public void BoundaryYear_2025_RecommendationIsFortnite()
        {
            gamesForYouPage.EnterYear("2025");
            gamesForYouPage.RequestGame();
            Assert.That(gamesForYouPage.GetRecommendationText(), Is.EqualTo("Neked a Fortnite-ot ajánljuk!"));
        }
    }
}
