
using OpenQA.Selenium;

namespace SzoftvertesztBeadando.pages
{
    public class LoginPage : BasePage
    {
        public static readonly string URL = "http://127.0.0.1:5500/login.html";
        public LoginPage(IWebDriver driver) : base(driver) { }

        By UsernameInput => By.Id("username");
        By PasswordInput => By.Id("password");
        By LoginButton => By.XPath("//button[contains(text(),'Belépés')]");
        By ErrorMessage => By.Id("login-error");

        public void GoTo() => driver.Navigate().GoToUrl(URL);

        public void Login(string username, string password)
        {
            Type(UsernameInput, username);
            Type(PasswordInput, password);
            Click(LoginButton);
        }

        public string GetErrorMessage() => Find(ErrorMessage).Text;
    }
}
