using System.Diagnostics.Contracts;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    [TestFixture]
    public class TestsForContacts : BaseForTest
    { 
        [Test]
        public void TheAddContactTestCase()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Contacts.InitContactCreating();
            ContactData contact = new ContactData("FirstNameTest", "MiddleTestName", "LastTestName", "ChoosenOneTest");
            app.Contacts.FIOAdding(contact);
            contact.Nickname = "ChoosenOne";
            contact.Title = "Test";
            contact.Company = "Test";
            contact.Home = "Test";
            contact.Address = "Test";
            contact.Mobile = "Test";
            contact.Work = "Test";
            contact.Fax = "Test";
            contact.Email = "Test";
            contact.HomePage = "Test";
            app.Contacts.FillFormContact(contact);
            app.Contacts.SubmitContactCreation();
            app.Auth.Logout();
        }
    }
}
