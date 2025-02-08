using OpenQA.Selenium;

namespace HospitalTest.Pages
{
    public class LoginPage: BasePage{

        private readonly By UsernameLocator = By.Id("username");
        private readonly By PasswordLocator = By.Id("password");
        private readonly By LocationLocator = By.Id("Registration Desk");
        private readonly By LoginButtonLocator = By.Id("loginButton");
        private readonly By ErrorMessajeLocator = By.CssSelector("li.nav-item.logout");
        public LoginPage(IWebDriver driver): base(driver){
        }
        
        public bool LoginMethod(String Username,String Password){
            Type(UsernameLocator,Username);
            Type(PasswordLocator,Password);
            Click(LocationLocator);
            Click(LoginButtonLocator);
            return IsDisplayed(ErrorMessajeLocator);
        }  
    }
 
}