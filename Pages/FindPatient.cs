using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace HospitalTest.Pages
{
    public class FindPatient:BasePage{
        
        private readonly By SearchBarLocator = By.Id("patient-search");
        private readonly By TablePatientLocator = By.CssSelector("tr.odd");
        private readonly By PatientIdlocator = By.XPath("//div[@class='float-sm-right']/span");
        
        private readonly By RecordVitalsLocator = By.Id("coreapps-vitals-confirm");
        public FindPatient(IWebDriver driver):base(driver){

        }
        public void OptionSearch(){
            Type(SearchBarLocator,IDPATIENT);
            Click(TablePatientLocator);
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(10));
            IWebElement patien = wait.Until(ExpectedConditions.ElementIsVisible(PatientIdlocator));
        }
        public bool SearchPatient(){
            OptionSearch();
            return IsDisplayed(PatientIdlocator);
        }

        public bool CaptureVitals(){
            OptionSearch();
            Click(RecordVitalsLocator);
            return IsDisplayed(PatientIdlocator);
        }
    }
}