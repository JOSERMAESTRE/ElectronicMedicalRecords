
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace HospitalTest.Pages
{
    public abstract class BasePage{
        protected IWebDriver driver;
        public static String IDPATIENT = "";
        public BasePage(IWebDriver driver){
            this.driver = driver;
        }

        public void GoToURL(String URL){
            driver.Navigate().GoToUrl(URL);
        }

        public IWebElement FindElement(By locator){
            return driver.FindElement(locator);
        }

        public void Type(By locator, String text){
            FindElement(locator).SendKeys(text);
        }

        public void Click(By locator){
            FindElement(locator).Click();
        }

        public void DropDownList(By locator,String value){
            WebDriverWait Wait = new WebDriverWait(driver,TimeSpan.FromSeconds(10));
            IWebElement DropDownList = Wait.Until(ExpectedConditions.ElementIsVisible(locator));

            SelectElement DropDown = new SelectElement(DropDownList);
            DropDown.SelectByValue(value);
        }

        public void DropDownListBy(By locator,String value){
            WebDriverWait Wait = new WebDriverWait(driver,TimeSpan.FromSeconds(10));
            IWebElement DropDownList = Wait.Until(ExpectedConditions.ElementIsVisible(locator));

            SelectElement DropDown = new SelectElement(DropDownList);
            DropDown.SelectByText(value);
        }
        public bool IsDisplayed(By locator){
            try
            {
                return driver.FindElement(locator).Displayed;
            }
            catch (NoSuchElementException)
            {
                
                return false;
            }
        }
    }    
}