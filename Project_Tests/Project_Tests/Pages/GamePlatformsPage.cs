
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using System.Linq;

namespace SzoftvertesztBeadando.pages
{
    public class GamePlatformsPage : BasePage
    {
        public static readonly string URL = "http://127.0.0.1:5500/platform_games.html";
        public GamePlatformsPage(IWebDriver driver) : base(driver) { }

        By FilterSelect => By.Id("filter");
        By ProductDivs => By.CssSelector("#filtered-products .games");
        By BackToMainButton => By.Id("BackToMain_btn");

        public void GoBackToMain()
        {
            Click(BackToMainButton);
        }


        public void SelectPlatform(string platform)
        {
            var selectElement = Find(FilterSelect);
            var options = selectElement.FindElements(By.TagName("option"));
            foreach (var option in options)
            {
                if (option.GetAttribute("value") == platform)
                {
                    option.Click();
                    break;
                }
            }
        }


        public ReadOnlyCollection<IWebElement> GetVisibleProducts()
        {
            return driver.FindElements(ProductDivs)
                .Where(e => e.Displayed)
                .ToList()
                .AsReadOnly();
        }
    }
}
