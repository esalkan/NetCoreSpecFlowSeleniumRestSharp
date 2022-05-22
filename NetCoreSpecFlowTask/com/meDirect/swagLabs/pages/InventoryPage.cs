using System;
using System.Collections.Generic;
using NetCoreSpecFlowTask.com.meDirect.toolbox;
using OpenQA.Selenium;

namespace NetCoreSpecFlowTask.com.meDirect.pages
{
    public class InventoryPage : BasePage
    {
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