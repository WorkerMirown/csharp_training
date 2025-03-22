using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class NavigationHelper : HelperBase  
    {
        
        private string baseURL;
        public NavigationHelper(ApplicationManager manager, string baseURL) : base(manager)
        { 
            this.baseURL = baseURL;
        }
        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseURL + "/addressbook");
        }
        public void GoToGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
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
