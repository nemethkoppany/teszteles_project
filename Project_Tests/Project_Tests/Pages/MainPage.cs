
using OpenQA.Selenium;

namespace SzoftvertesztBeadando.pages
{
    public class MainPage : BasePage
    {
        public static readonly string URL = "http://127.0.0.1:5500/main_page.html";
        public MainPage(IWebDriver driver) : base(driver) { }

        By PlatformButton => By.XPath("//button[contains(text(),'Platformok')]");
        By GameForYouButton => By.XPath("//button[contains(text(),'Játék ajánló')]");
        By LogoutButton => By.XPath("//button[contains(text(),'Kijelentkezés')]");

        public void GoToProducts() => Click(PlatformButton);
        public void GoToCart() => Click(GameForYouButton);
        public void Logout() => Click(LogoutButton);
    }
}
