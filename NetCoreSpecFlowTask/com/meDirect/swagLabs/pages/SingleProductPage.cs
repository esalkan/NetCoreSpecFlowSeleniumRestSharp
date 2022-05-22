using NetCoreSpecFlowTask.com.meDirect.toolbox;
using OpenQA.Selenium;

namespace NetCoreSpecFlowTask.com.meDirect.pages
{
    public class SingleProductPage : BasePage
    {

        // UI Elements
        public IWebElement productDetailName => 
            Driver.getDriver().FindElement(By.XPath("//div[@class='inventory_details_name large_size']"));
        public IWebElement productDetailDescription => 
            Driver.getDriver().FindElement(By.XPath("//div[@class='inventory_details_desc large_size']"));
        public IWebElement productDetailPrice => 
            Driver.getDriver().FindElement(By.XPath("//div[@class='inventory_details_price']"));
        
        public IWebElement addToCartButton => 
            Driver.getDriver().FindElement(By.XPath("//button[starts-with(@id,'add-to-cart')]"));
        
        public IWebElement backToProducts => 
            Driver.getDriver().FindElement(By.XPath("//button[@data-test='back-to-products']"));

        public string getSingleProductName()
        {
            return productDetailName.Text;
        }
        
        public string getSingleProductDescription()
        {
            return productDetailDescription.Text;
        }
        
        public string getSingleProductPrice()
        {
            return productDetailPrice.Text.Substring(1);
        }
        
        public void clickAddToCartButton()
        {
            addToCartButton.Click();
        }
        
        public void clickBackToProducts()
        {
            backToProducts.Click();
        }
    }
}

