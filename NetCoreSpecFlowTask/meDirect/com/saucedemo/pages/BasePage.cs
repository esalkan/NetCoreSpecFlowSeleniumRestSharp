using System;
using System.Collections.Generic;
using NetCoreSpecFlowTask.meDirect.com.saucedemo.toolbox;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

/*
 * @author esalkan
 * @vcard https://esalkan.com
 * @project MeDirect - Skill Assessment
 * @type Web & Api Automation 
 * @repo https://github.com/esalkan/AutomationNetCoreSpecFlowSelenium.git
 */
namespace NetCoreSpecFlowTask.meDirect.com.saucedemo.pages
{
    // Page Object
    public abstract class BasePage
    {
        // UI Elements
        public IWebElement pageTitle =>
            Driver.getDriver().FindElement(By.XPath("//span[@class='title']"));
        
        public IWebElement hamburgerMenu => 
            Driver.getDriver().FindElement(By.Id("react-burger-menu-btn"));
        
        public IWebElement logOutBtn => 
            Driver.getDriver().FindElement(By.Id("logout_sidebar_link"));

        public IWebElement shoppingCartBtn => 
            Driver.getDriver().FindElement(By.CssSelector("div>a.shopping_cart_link"));
        
        
        // This is the base page class that all other pages will inherit from.
        protected BasePage() // This is the constructor for the base page class.
        {
            PageFactory.InitElements(Driver.getDriver(), this); // This initializes the elements of the page.
        }
        
        // Getting Actual Page Title from the page.
        public string GetActualTitle()
        {
            return Driver.getDriver().Title;
        }
        
        // Getting Actual Page Url from the page.
        public string GetActualPageUrl()
        {
            return Driver.getDriver().Url;
        }

        // click on add to cart button method
        public void AddToCartBtn()
        {
            Driver.getDriver().FindElement(By.XPath("//button[starts-with(@id,'add-to-cart')]")).Click();
        }

        // Click on shopping cart button method
        public void ShoppingCartBtn()
        {
            Driver.getDriver().FindElement(By.XPath("//a[@class='shopping_cart_link']")).Click();
        }

        // click on checkout button method
        public void CheckOutBtn()
        {
            Driver.getDriver().FindElement(By.XPath("//button[@id='checkout']")).Click();   
        }

        // This method will select random product from the list of products.
        public IWebElement selectARandomProduct()
        {
            var random = new Random();
            var list = new List<IWebElement>(
                Driver.getDriver().FindElements(By.XPath("//div[@class='inventory_item_name']")));
            var productList = new List<string>();
            
            foreach (IWebElement element in list)
            {
                productList.Add(element.Text);
            }
            var randomProduct = random.Next(productList.Count)+1;
            return Driver.getDriver().FindElement(By.XPath("(//div[@class='inventory_item_label']/a)["+ randomProduct+"]"));
        }

        
        
    }
}