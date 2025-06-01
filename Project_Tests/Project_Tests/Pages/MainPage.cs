
using OpenQA.Selenium;
using System.Collections.ObjectModel;

namespace SzoftvertesztBeadando.pages
{
    public class MainPage : BasePage
    {
        public static readonly string URL = "http://127.0.0.1:5500/main_page.html";
        public MainPage(IWebDriver driver) : base(driver) { }

        By PlatformButton => By.Id("PlatformGamesPage_btn");
        By GameForYouButton => By.Id("GameForYouPage_btn");
        By LogoutButton => By.Id("LogoutPage_btn");
        By DetailsButtons => By.CssSelector(".games button");
        By DetailsParagraphs => By.CssSelector(".games .details");
        public ReadOnlyCollection<IWebElement> GetDetailsButtons() => driver.FindElements(DetailsButtons);
        public ReadOnlyCollection<IWebElement> GetDetailsParagraphs() => driver.FindElements(DetailsParagraphs);

        public void ClickDetailsButton(int index)
        {
            GetDetailsButtons()[index].Click();
        }

        public bool IsDetailsVisible(int index)
        {
            var details = GetDetailsParagraphs()[index];
            return details.Displayed && !details.GetAttribute("class").Contains("hidden");
        }

        public bool IsDetailsHidden(int index)
        {
            var details = GetDetailsParagraphs()[index];
            return !details.Displayed || details.GetAttribute("class").Contains("hidden");
        }
        public void GoToPlatformGames() => Click(PlatformButton);
        public void GoToGameForYou() => Click(GameForYouButton);
        public void Logout() => Click(LogoutButton);
    }
}
