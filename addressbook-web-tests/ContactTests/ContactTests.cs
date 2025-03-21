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
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            InitContactCreating();
            ContactData contact = new ContactData("FirstNameTest", "MiddleTestName", "LastTestName", "ChoosenOneTest");
            FIOAdding(contact);
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
            FillFormContact(contact);
            SubmitContactCreation();
            Logout();
        }
    }
}
