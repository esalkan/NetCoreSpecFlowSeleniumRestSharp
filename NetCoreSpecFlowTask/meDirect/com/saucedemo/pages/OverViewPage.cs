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
    public class OverViewPage
    {
        public IWebElement overViewProductName => Driver.getDriver().FindElement(By.XPath("//div[@class='inventory_item_name']"));
        public IWebElement overViewProductPrice => Driver.getDriver().FindElement(By.XPath("//div[@class='inventory_item_price']"));
        public IWebElement overViewProductDescription => Driver.getDriver().FindElement(By.XPath("//div[@class='inventory_item_desc']"));

            public string getProductName()
        {
            return overViewProductName.Text;
        }
        public string getProductPrice()
        {
            return overViewProductPrice.Text.Substring(1);
        }
        
        public string getProductDescription()
        {
            return overViewProductDescription.Text;
        }
    }
}