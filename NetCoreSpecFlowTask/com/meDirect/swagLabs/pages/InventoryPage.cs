using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using NetCoreSpecFlowTask.com.meDirect.toolbox;
using OpenQA.Selenium;

namespace NetCoreSpecFlowTask.com.meDirect.pages
{
    public class InventoryPage : BasePage
    {
        public IList<IWebElement> InventoryItems =>
            Driver.getDriver().FindElements(By.XPath("//div[@class='inventory_item_name']"));
        
    }
}