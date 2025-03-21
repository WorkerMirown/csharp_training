using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class NavigationHelper : HelperBase  
    {
        private IWebDriver driver;
        private string baseURL;
        public NavigationHelper(IWebDriver driver, string baseURL) : base(driver)
        { 
            this.baseURL = baseURL;
        }
        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseURL + "addressbook");
        }
        public void GoToGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
        public void ReturnToGroupPage()
        {
            driver.FindElement(By.LinkText("group page")).Click();
        }
        public void ReturnAfterDelete()
        {
            driver.FindElement(By.LinkText("home")).Click();
        }
        public void PressDeleteButtonForContact()
        {
            driver.FindElement(By.XPath("//*[@id=\"content\"]/form[2]/div[2]/input")).Click();
        }
    }
}
