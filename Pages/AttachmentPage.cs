using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace HospitalTest.Pages
{
    public class AttachmentPage:BasePage{

         private readonly By AttachmentLocator = By.CssSelector(".icon-share-alt.edit-action.right");
         private readonly By FileUploaderLocator = By.Id("visit-documents-dropzone");
        private readonly By PatientIdlocator = By.XPath("//div[@class='float-sm-right']/span");
        private readonly By DescriptionLocator = By.TagName("textarea");
        private readonly By UploadFileLocator = By.CssSelector(".confirm.ng-binding");
        
        public AttachmentPage(IWebDriver driver):base(driver){

        }

        public bool UpdateFile(){
            Console.WriteLine(driver.FindElements(AttachmentLocator));
            Click(AttachmentLocator);
            WebDriverWait wait = new WebDriverWait(driver,TimeSpan.FromSeconds(10));
            IWebElement Upload = wait.Until(ExpectedConditions.ElementIsVisible(FileUploaderLocator));

            String FilePath = @"C:\Users\Jose R\OneDrive\Imágenes\Screenshot-2023-03-10-173915.png";

            IWebElement FileInput = FindElement(By.CssSelector("input[Type='file']"));
            FileInput.SendKeys(FilePath);
            Type(DescriptionLocator,"Photo");
            Click(UploadFileLocator);
            IWebElement SucessMessage = wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(".toast-item-close")));
            return SucessMessage.Displayed;
        }
    }
}