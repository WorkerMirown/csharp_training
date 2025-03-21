using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using NUnit.Framework.Internal.Commands;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace WebAddressbookTests 
{
    public class BaseForTest 
    {
        protected IWebDriver driver;
        private StringBuilder verificationErrors;
        protected string baseURL;
        private bool acceptNextAlert = true;

        protected ApplicationManager app;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "http://localhost/";
            verificationErrors = new StringBuilder();

            app = new ApplicationManager();
    }

    [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Dispose();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
    }
}
