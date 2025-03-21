namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupDelete : BaseForTest
    {
        [Test]
        public void TheGroupDeleteTest()
        {
            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToGroupsPage();
            app.Groups.SelectGroup(1);
            app.Groups.PressDeleteButtonForGroup();
            app.Navigator.ReturnToGroupPage();
            app.Auth.Logout();
        }
    }
}
