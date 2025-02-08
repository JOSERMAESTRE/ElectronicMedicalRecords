using Allure.NUnit;
using NUnit.Framework;

namespace HospitalTest.Tests
{   
    [AllureNUnit]
    public class Test : BaseTest
    {
        [Test,Order(1)]
        public void RegisterPatient()
        {
             string[] Data = new string[] {
                "jose", "Rafael", "Master Wayne", "M", "10", "10", "1991",
                "calle 93A - 14, Chapinero", "Bogota", "Colombia", "200005", "3156782314", "Aunt/Uncle", "Isaura"
            };
            Assert.That(dashboard.ClickRegister(), Is.True, "Register Patient");
            Assert.That(registerPage.RegisterMethod(Data), Is.True, "Patient Registered");
        }

        [Test,Order(2)]
        public void StarVisit()
        {
            string []Data = new string[]{
                "Hemorrhagic diarrhea","Abdominal or pelvic pain"
            };
            Assert.That(dashboard.ClickFindPatient, Is.True, "Find Patient");
            Assert.That(findPatient.SearchPatient(), Is.True, "Patient Found Successfully");
            Assert.That(startVisit.StartVisitMethod(),Is.True,"Visit started");
            Assert.That(visitNote.VisitNoteMethod(Data,"lorem ipsum dolor sit amet consectetur adipiscing elit. in semper lorem ut dolor iaculis porta"),Is.True,"Visist Note succesfully Created");
        }

        [Test,Order(3)]
        public void CaptureVital()
        {
            Assert.That(dashboard.ClickcaptureVitals, Is.True, "Find Patient");
            Assert.That(findPatient.CaptureVitals(), Is.True, "Patient Found Successfully");
            string[] Data = new string[] {
                "180", "81", "32", "120", "80", "130",
                "70", "70"
            };
            Assert.That(vitalsPage.VitalsMethod(Data), Is.True, "Vitals Captured Successfully");
        }

        [Test,Order(4)]
        public void AttachFile(){
            Assert.That(dashboard.ClickFindPatient, Is.True, "Find Patient");
            Assert.That(findPatient.SearchPatient(), Is.True, "Patient Found Successfully");
            Assert.That(attachmentPage.UpdateFile(), Is.True, "Patient Found Successfully");

        }
    }
}