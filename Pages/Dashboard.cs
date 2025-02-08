using OpenQA.Selenium;

namespace HospitalTest.Pages
{   
    public class Dashboard: BasePage{

        private readonly By RegisterPatientLocator = By.Id("referenceapplication-registrationapp-registerPatient-homepageLink-referenceapplication-registrationapp-registerPatient-homepageLink-extension");
        private readonly By RegisterPatientPageLocator = By.XPath("//h2[contains(text(),'Register')]");
        private readonly By FindPatientLocator = By.Id("coreapps-activeVisitsHomepageLink-coreapps-activeVisitsHomepageLink-extension");
        private readonly By FindPatientPageLocator = By.XPath("//h2[contains(text(),'Patient')]");
        private readonly By CaptureVitalsLocator = By.Id("referenceapplication-vitals-referenceapplication-vitals-extension");
        private readonly By CreateVitalsPageLocator = By.XPath("//h2[contains(text(),'Vitals')]");
        public Dashboard(IWebDriver driver): base(driver){

        }

        public bool ClickRegister(){
            Click(RegisterPatientLocator);
            return IsDisplayed(RegisterPatientPageLocator);
        }

        public bool ClickFindPatient(){
            Click(FindPatientLocator);
            return IsDisplayed(FindPatientPageLocator);
        }
        public bool ClickcaptureVitals(){
            Click(CaptureVitalsLocator);
            return IsDisplayed(CreateVitalsPageLocator);
        }

    }
}