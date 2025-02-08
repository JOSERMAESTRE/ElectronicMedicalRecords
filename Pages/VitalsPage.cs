    using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace HospitalTest.Pages
    {
        public class VitalsPage:BasePage{

            private readonly By HeightLocator = By.Id("w8");
            private readonly By NextButtonLocator = By.Id("next-button");
            private readonly By WeightLocator = By.Id("w10");
            private readonly By BMILocator = By.Id("calculated-bmi");
            private readonly By TemperatureLocator = By.Id("w12");
            private readonly By PulseLocator = By.Id("w14");
            private readonly By Respiratory = By.Id("w16");
            private readonly By systolicLocator = By.Id("w18");
            private readonly By DiastolicLocator = By.Id("w20");
            private readonly By BloodOxygenLocator = By.Id("w22");

            private readonly By SaveVitalsLocator = By.XPath("//button[@type='submit']");
            private readonly By CaptureVitalsLocator = By.XPath("//div[@id='content']/h2");
            public VitalsPage(IWebDriver driver):base(driver){

            }
            public bool VitalsMethod(String [] Data){
            Type(HeightLocator,Data[0]);
            Click(NextButtonLocator);
            Type(WeightLocator,Data[1]);
            Click(NextButtonLocator);
            IsDisplayed(BMILocator);
            Click(NextButtonLocator);
            Type(TemperatureLocator,Data[2]);
            Click(NextButtonLocator);
            Type(PulseLocator,Data[3]);
            Click(NextButtonLocator);
            Type(Respiratory,Data[4]);
            Click(NextButtonLocator);
            Type(systolicLocator,Data[5]);
            Type(DiastolicLocator,Data[6]);
            Click(NextButtonLocator);
            Type(BloodOxygenLocator,Data[7]);
            Click(NextButtonLocator);
            Click(SaveVitalsLocator);
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(10));
            wait.Until(ExpectedConditions.ElementIsVisible(CaptureVitalsLocator));
            return IsDisplayed(CaptureVitalsLocator);
            }
        }
    }