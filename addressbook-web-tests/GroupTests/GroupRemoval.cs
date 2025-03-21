namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupDelete : BaseForTest
    {
        [Test]
        public void TheGroupDeleteTest()
        {
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            GoToGroupsPage();
            SelectGroup(1);
            PressDeleteButtonForGroup();
            ReturnToGroupPage();
        }
    }
}
