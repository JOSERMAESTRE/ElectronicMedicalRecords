using HospitalTest.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HospitalTest.Tests
{
    public abstract class BaseTest
    {
        protected IWebDriver driver;
        protected LoginPage loginPage;
        protected Dashboard dashboard;
        protected RegisterPage registerPage;
        protected FindPatient findPatient;
        protected VitalsPage vitalsPage;
        protected StartVisit startVisit;
        protected AttachmentPage attachmentPage;
        protected VisitNote visitNote;
        [SetUp]
        public void BeforeTest()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            loginPage = new LoginPage(driver);
            loginPage.GoToURL("https://demo.openmrs.org/openmrs/referenceapplication/login.page");
            dashboard = new Dashboard(driver);
            registerPage = new RegisterPage(driver);
            findPatient = new FindPatient(driver);
            vitalsPage = new VitalsPage(driver);
            startVisit = new StartVisit(driver);
            attachmentPage = new AttachmentPage(driver);
            visitNote = new VisitNote(driver);
            Assert.That(loginPage.LoginMethod("Admin", "Admin123"), Is.True, "Login Successful");
        }

        [TearDown]
        public void CloseBrowser()
        {
            driver.Quit();
        }
    }
}