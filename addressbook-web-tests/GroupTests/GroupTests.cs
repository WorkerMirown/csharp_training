namespace WebAddressbookTests
{
    [TestFixture]
    public class TestsForGroups : BaseForTest
    {
        [Test]
        public void CreateNewGroup()
        {
            navigator.GoToHomePage();
            loginHelper.Login(new AccountData("admin", "secret"));
            navigator.GoToGroupsPage();
            contactHelper.InitGroupCreation();
            GroupData group = new GroupData("aaa");
            group.Header = "sss";
            group.Footer = "footer";
            groupHelper.FillGroupForm(group);
            groupHelper.PressSubmitButton();
            navigator.ReturnToGroupPage();
            loginHelper.Logout();
        }
    }
}
