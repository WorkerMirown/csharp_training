namespace WebAddressbookTests
{
    [TestFixture]
    public class GroupDelete : BaseForTest
    {
        [Test]
        public void TheGroupDeleteTest()
        {
            app.Groups.Remove(1);
        }
    }
}
