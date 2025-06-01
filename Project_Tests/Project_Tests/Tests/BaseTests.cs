
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SzoftvertesztBeadando.pages;

namespace SzoftvertesztBeadando.tests
{
    public class BaseTests
    {
        protected IWebDriver driver;
        protected LoginPage loginPage;
        protected MainPage mainPage;
        protected GamePlatformsPage gamePlatformsPage;
        protected GamesForYouPage gamesForYouPage;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            loginPage = new LoginPage(driver);
            mainPage = new MainPage(driver);
            gamePlatformsPage = new GamePlatformsPage(driver);
            gamesForYouPage = new GamesForYouPage(driver);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
