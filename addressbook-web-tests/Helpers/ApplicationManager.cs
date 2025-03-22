using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Text;

namespace WebAddressbookTests
{
    public class ApplicationManager
    {       
        
        protected string baseURL;

        protected LoginHelper loginHelper;
        protected NavigationHelper navigationHelper;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;

        private FirefoxDriver driver;
        private bool acceptNextAlert = true;
        private StringBuilder verificationErrors;

        public ApplicationManager()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost";
            verificationErrors = new StringBuilder();

            loginHelper = new LoginHelper(this);
            navigationHelper = new NavigationHelper(this, baseURL);
            groupHelper = new GroupHelper(this); 
            contactHelper = new ContactHelper(this);
        }
        public IWebDriver Driver 
        { get { return driver; } }
        public void Stop()
        {
            try
            {
                driver.Dispose();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
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
