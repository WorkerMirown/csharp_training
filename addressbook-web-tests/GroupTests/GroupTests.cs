namespace WebAddressbookTests
{
    [TestFixture]
    public class TestsForGroups : BaseForTest
    {
        [Test]
        public void CreateNewGroup()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToGroupsPage();
            app.Groups.InitGroupCreation();
            GroupData group = new GroupData("aaa");
            group.Header = "sss";
            group.Footer = "footer";
            app.Groups.FillGroupForm(group);
            app.Groups.PressSubmitButton();
            app.Navigator.ReturnToGroupPage();
            app.Auth.Logout();
        }
    }
}
