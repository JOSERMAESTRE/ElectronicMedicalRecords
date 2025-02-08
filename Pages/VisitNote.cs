using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace HospitalTest.Pages
{
    public class VisitNote:BasePage{
        private readonly By CreateVisitnotebutton = By.Id("referenceapplication.realTime.simpleVisitNote");
        private readonly By DiagnosisLocator =  By.Id("diagnosis-search");
        private readonly By ClinicalNoteLocator = By.Id("w10");
        private readonly By SaveButtonLocator = By.CssSelector(".submitButton.confirm.right");
        private readonly By ComfirmButtonLocator = By.XPath("//input[@data-ng-model='d.confirmed']");
        private readonly By ConfirmVisitDiagnosis = By.XPath("//h4[contains(text(),'Encounters')]");
        public VisitNote(IWebDriver driver):base(driver){}

        public bool VisitNoteMethod(String[] Data,String ClinicalNote){
        WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(10));
        Click(CreateVisitnotebutton);
        foreach (var diagnosis in Data)
        {
            Type(DiagnosisLocator,diagnosis);
            IWebElement DiagnosisList = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath($"//strong[contains(text(),'{diagnosis}')]")));
            DiagnosisList.Click();
        }
        IList<IWebElement> ComfirmDiagnosis = driver.FindElements(ComfirmButtonLocator);
        foreach (IWebElement Button in ComfirmDiagnosis){
            Button.Click();
        }
        Type(ClinicalNoteLocator,ClinicalNote);
        Click(SaveButtonLocator);
        wait.Until(ExpectedConditions.ElementIsVisible(ConfirmVisitDiagnosis));
        return FindElement(ConfirmVisitDiagnosis).Text.Equals("Encounters");
        }
        
    }
}