using NetCoreSpecFlowTask.com.meDirect.toolbox;
using OpenQA.Selenium;

namespace NetCoreSpecFlowTask.com.meDirect.pages
{
    public class InventoryPage : BasePage
    {
        public IWebElement hamburgerMenu => Driver.getDriver().FindElement(By.Id("react-burger-menu-btn"));

        public IWebElement logOutBtn => Driver.getDriver().FindElement(By.Id("logout_sidebar_link"));

        public void GetLogOut()
        {
            hamburgerMenu.Click();
            logOutBtn.Click();
        }
    }
}