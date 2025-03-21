using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Text;

namespace WebAddressbookTests
{
    public class ApplicationManager
    {       
        protected IWebDriver driver;
        private StringBuilder verificationErrors;

        protected string baseURL;
        private bool acceptNextAlert = true;

        protected LoginHelper loginHelper;
        protected NavigationHelper navigationHelper;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;

        public ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/";
            verificationErrors = new StringBuilder();

            loginHelper = new LoginHelper(driver);
            navigationHelper = new NavigationHelper(driver, baseURL);
            groupHelper = new GroupHelper(driver); 
            contactHelper = new ContactHelper(driver);
        }

        public LoginHelper Auth 
        { get {  return loginHelper; } }
        public NavigationHelper Navigator
        {get { return navigationHelper; } }
        public GroupHelper Groups 
        { get { return groupHelper; } }
        public ContactHelper Contacts 
        {  get { return contactHelper; } }
    }
}
