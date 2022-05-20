using NetCoreSpecFlowTask.com.meDirect.toolbox;
using OpenQA.Selenium;

namespace NetCoreSpecFlowTask.com.meDirect.pages
{
    // This class is used to define the elements on the page
    public class InventoryPage : BasePage
    {
        // UI Elements
        public IWebElement hamburgerMenu => Driver.getDriver().FindElement(By.Id("react-burger-menu-btn"));
        public IWebElement logOutBtn => Driver.getDriver().FindElement(By.Id("logout_sidebar_link"));

        // Logout method for the user to logout from the application
        public void GetLogOut()
        {
            hamburgerMenu.Click();
            logOutBtn.Click();
        }
    }
}