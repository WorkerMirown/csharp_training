using OpenQA.Selenium;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactDelete : BaseForTest
    {
        [Test]
        public void TheContactDeleteTest()
        {
            navigator.GoToHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            contactHelper.MarkContactCard(contactHelper.GetFirstIdFromContactTable());
            navigator.PressDeleteButtonForContact();
            navigator.ReturnAfterDelete();
            loginHelper.Logout();
        }

    }
}
