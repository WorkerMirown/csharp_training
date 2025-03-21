using OpenQA.Selenium;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactDelete : BaseForTest
    {
        [Test]
        public void TheContactDeleteTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Contacts.MarkContactCard(app.Contacts.GetFirstIdFromContactTable());
            app.Navigator.PressDeleteButtonForContact();
            app.Navigator.ReturnAfterDelete();
            app.Auth.Logout();
        }

    }
}
