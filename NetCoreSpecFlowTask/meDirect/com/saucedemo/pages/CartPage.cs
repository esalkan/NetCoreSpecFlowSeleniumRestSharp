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
    public class CartPage : BasePage
    {

        // UI Web Elements for Cart Page usage for the application

        // Selected product name
        public IWebElement cartProductName =>
            Driver.getDriver().FindElement(By.XPath("//div[@class='inventory_item_name']"));
        
        // Selected product Description
        public IWebElement cartProductDescription =>
            Driver.getDriver().FindElement(By.XPath("//div[@class='inventory_item_desc']"));
        
        // Selected product price
        public IWebElement cartProductPrice =>
            Driver.getDriver().FindElement(By.XPath("//div[@class='inventory_item_price']"));
        
        // Remove button
        public IWebElement cartRemoveButton =>
            Driver.getDriver().FindElement(By.XPath("//button[starts-with(@id,'remove-')]"));
        
        // Checkout button
        public IWebElement cartCheckOutButton =>
            Driver.getDriver().FindElement(By.Id("checkout"));

        // Continue Shopping button
        public IWebElement cartContinueShoppingButton =>
            Driver.getDriver().FindElement(By.Id("continue-shopping"));
        
        public IWebElement removedCartItem =>
            Driver.getDriver().FindElement(By.XPath("//div[@class='removed_cart_item']"));
        
        // This method is used to get the product name from the cart page
        public string getCardProductName()
        {
            return cartProductName.Text;
        }
        
        // This method is used to get the product description from the cart page
        public string getCardProductDescription()
        {
            return cartProductDescription.Text;
        }
        
        // This method is used to get the product price from the cart page
        public string getCardProductPrice()
        {
            return cartProductPrice.Text.Substring(1);
        }
        
        // This method is used to click on checkout button
        public void clickOnCheckOutBtn()
        {
            cartCheckOutButton.Click();
        }
    }
}