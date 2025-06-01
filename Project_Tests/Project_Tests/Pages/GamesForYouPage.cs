
using OpenQA.Selenium;

namespace SzoftvertesztBeadando.pages
{
    public class GamesForYouPage : BasePage
    {
        public static readonly string URL = "http://127.0.0.1:5500/gameForYou.html";
        public GamesForYouPage(IWebDriver driver) : base(driver) { }

        By AgeInput => By.Id("age");
        By GetGameButton => By.XPath("//button[contains(text(),'Kérem a játékom!')]");
        By Recommendation => By.CssSelector(".recommendation p");

        public void EnterYear(string year)
        {
            Type(AgeInput, year);
        }

        public void RequestGame()
        {
            Click(GetGameButton);
        }

        public string GetRecommendationText()
        {
            return Find(Recommendation).Text;
        }
    }
}
