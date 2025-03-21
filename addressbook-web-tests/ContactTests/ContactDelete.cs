using OpenQA.Selenium;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactDelete : BaseForTest
    {
        [Test]
        public void TheContactDeleteTest()
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            MarkContactCard(GetFirstIdFromContactTable());
            PressDeleteButtonForContact();
            ReturnAfterDelete();
        }
        
    }
}
