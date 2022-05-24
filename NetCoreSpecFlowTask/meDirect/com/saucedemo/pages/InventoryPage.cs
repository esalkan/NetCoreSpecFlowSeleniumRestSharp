using System.Collections.Generic;
using NetCoreSpecFlowTask.meDirect.com.saucedemo.toolbox;
using OpenQA.Selenium;
/*
 * @author esalkan
 * @vcard https://esalkan.com
 * @project MeDirect - Skill Assessment
 * @type Web & Api Automation 
 * @repo https://github.com/esalkan/AutomationNetCoreSpecFlowSelenium.git
 */
namespace NetCoreSpecFlowTask.meDirect.com.saucedemo.pages
{
    public class InventoryPage : BasePage
    {
        public IList<IWebElement> InventoryItems =>
            Driver.getDriver().FindElements(By.XPath("//div[@class='inventory_item_name']"));
        
    }
}