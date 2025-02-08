using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace HospitalTest.Pages{
    public class StartVisit:BasePage{
        
        private readonly By StartVisitLocator = By.Id("org.openmrs.module.coreapps.createVisit");
        private readonly By DialogLocator = By.Id("quick-visit-creation-dialog");
        private readonly By ConfirmButtonLocator = By.Id("start-visit-with-visittype-confirm");
        private readonly By PatientVisitlocator = By.XPath("//a[@href='#visits']");
        public StartVisit (IWebDriver driver):base(driver){

        }
        public bool StartVisitMethod(){
            Click(StartVisitLocator);
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(DialogLocator));
            IWebElement ConfirmButton = wait.Until(ExpectedConditions.ElementToBeClickable(ConfirmButtonLocator));
            ConfirmButton.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(PatientVisitlocator));
            return IsDisplayed(PatientVisitlocator);
        }
    }

    
}