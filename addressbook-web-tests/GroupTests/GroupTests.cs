namespace WebAddressbookTests
{
    [TestFixture]
    public class TestsForGroups : BaseForTest
    {
        [Test]
        public void CreateNewGroup()
        { 
            GroupData group = new GroupData("aaa");
            group.Header = "sss";
            group.Footer = "footer";
            
            app.Groups.Create(group);
            app.Auth.Logout();
        }
        [Test]
        public void EmptyCreateNewGroup()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";
           
            app.Groups.Create(group);
            app.Auth.Logout();
        }
    }
}
