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
    public class CheckOutStepTwoPage : BasePage
    {
        public IWebElement overViewQTY => 
            Driver.getDriver().FindElement(By.XPath("//div[@class='cart_quantity']"));
        
        public IWebElement overViewProductName =>
            Driver.getDriver().FindElement(By.XPath("//div[@class='inventory_item_name']"));
        
        public IWebElement overViewProductDescription =>
            Driver.getDriver().FindElement(By.XPath("//div[@class='inventory_item_desc']"));
        
        public IWebElement overViewProductPrice =>
            Driver.getDriver().FindElement(By.XPath("//div[@class='inventory_item_price']"));
        
        public IWebElement overViewItemTotal =>
            Driver.getDriver().FindElement(By.XPath("//div[@class='summary_subtotal_label']"));
        
        public IWebElement overViewTax =>
            Driver.getDriver().FindElement(By.XPath("//div[@class='summary_tax_label']"));
        
        public IWebElement overViewTotal =>
            Driver.getDriver().FindElement(By.XPath("//div[@class='summary_total_label']"));
        
        public IWebElement overViewFinishButton =>
            Driver.getDriver().FindElement(By.XPath("//button[@id='finish']"));
        
        public IWebElement overViewCancelButton =>
            Driver.getDriver().FindElement(By.XPath("//button[@id='cancel']"));
        
    }
}