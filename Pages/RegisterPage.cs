using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace HospitalTest.Pages
{
    public class RegisterPage:BasePage{

        private readonly By GivenLocator = By.Name("givenName");
        private readonly By MiddleNameLocator = By.Name("middleName");
        
        private readonly By FamilyNameLocator = By.Name("familyName");
        private readonly By NextButtonLocator = By.Id("next-button");
        private readonly By GenderLocator = By.Id("gender-field");
        private readonly By DayBirthLocator = By.Id("birthdateDay-field");
        private readonly By MonthBirthLocator = By.Id("birthdateMonth-field");
        private readonly By YearMothLocator = By.Id("birthdateYear-field");
        private readonly By AddresLocator = By.Id("address1");
        private readonly By CityLocator = By.Id("cityVillage");
        private readonly By CountryLocator = By.Id("country");
        private readonly By ZipCodeLocator = By.Id("postalCode");
        private readonly By PhoneNumerLocator = By.Name("phoneNumber");
        private readonly By RelatedLocator = By.Id("relationship_type");
        private readonly By RelatedNameLocator = By.XPath("//input[@ng-model='relationship.name']");
        private readonly By ConfirmLocator = By.Id("submit");
        private readonly By PatientIdlocator = By.XPath("//div[@class='float-sm-right']/span");
      

        public RegisterPage(IWebDriver driver):base(driver){

        }

        public bool RegisterMethod(String[] Data){
            Type(GivenLocator,Data[0]);
            Type(MiddleNameLocator,Data[1]);
            Type(FamilyNameLocator,Data[2]);
            Click(NextButtonLocator);
            DropDownList(GenderLocator,Data[3]);
            Click(NextButtonLocator);
            Type(DayBirthLocator,Data[4]);
            DropDownList(MonthBirthLocator,Data[5]);
            Type(YearMothLocator,Data[6]);
            Click(NextButtonLocator);
            Type(AddresLocator,Data[7]);
            Type(CityLocator,Data[8]);
            Type(CountryLocator,Data[9]);
            Type(ZipCodeLocator,Data[10]);
            Click(NextButtonLocator);
            Type(PhoneNumerLocator,Data[11]);
            Click(NextButtonLocator);
            DropDownListBy(RelatedLocator,Data[12]);
            Type(RelatedNameLocator,Data[13]);
            Click(NextButtonLocator);
            Click(ConfirmLocator);
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(10));
            IWebElement patien = wait.Until(ExpectedConditions.ElementIsVisible(PatientIdlocator));
            IDPATIENT = patien.Text.ToString();
            //Console.WriteLine(IDPATIENT+"This is "+Data[0]+" ID");
            return IsDisplayed(PatientIdlocator);
        }
    }
}