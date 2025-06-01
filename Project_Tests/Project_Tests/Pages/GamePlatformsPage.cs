
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
        By ProductDivs => By.CssSelector("#filtered-products .product");

        public void SelectPlatform(string platform)
        {
            var select = new OpenQA.Selenium.Support.UI.SelectElement(Find(FilterSelect));
            select.SelectByValue(platform);
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
