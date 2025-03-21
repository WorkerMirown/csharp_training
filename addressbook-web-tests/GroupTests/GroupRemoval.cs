namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupDelete : BaseForTest
    {
        [Test]
        public void TheGroupDeleteTest()
        {
            navigator.GoToHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigator.GoToGroupsPage();
            groupHelper.SelectGroup(1);
            groupHelper.PressDeleteButtonForGroup();
            navigator.ReturnToGroupPage();
            loginHelper.Logout();
        }
    }
}
