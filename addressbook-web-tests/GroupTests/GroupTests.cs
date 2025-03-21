namespace WebAddressbookTests
{
    [TestFixture]
    public class TestsForGroups : BaseForTest
    {
        [Test]
        public void CreateNewGroup()
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            InitGroupCreation();
            GroupData group = new GroupData("aaa");
            group.Header = "sss";
            group.Footer = "footer";
            FillGroupForm(group);
            PressSubmitButton();
            ReturnToGroupPage();
            Logout();
        }
    }
}
