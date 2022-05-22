using NetCoreSpecFlowTask.com.meDirect.toolbox;
using OpenQA.Selenium;

namespace NetCoreSpecFlowTask.com.meDirect.pages
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