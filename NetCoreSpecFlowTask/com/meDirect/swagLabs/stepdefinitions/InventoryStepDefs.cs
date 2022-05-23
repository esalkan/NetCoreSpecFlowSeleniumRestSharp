
using System;
using System.Collections.Generic;
using System.Linq;
using NetCoreSpecFlowTask.com.meDirect.pages;
using NetCoreSpecFlowTask.com.meDirect.toolbox;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NetCoreSpecFlowTask.com.meDirect.swagLabs.stepdefinitions
{
    [Binding]
    public sealed class InventoryStepDefs
    {
        InventoryPage _inventory = new InventoryPage();
        
        [Then(@"verify that user see following products on inventory page")]
        public void ThenVerifyThatUserSeeFollowingProductsOnInventoryPage(Table table)
        {
            /*
            List<string> actualProductList = BrowserUtilities.getElementsText(_inventory.InventoryItems);
            Assert.AreEqual(expectedProductList, actualProductList);
            */
            
           List<string> expectedProductList = table.CreateSet<string>().ToList();

           foreach (var expectedProduct in expectedProductList)
           {
               Assert.IsTrue(_inventory.InventoryItems.Any(x => x.Text.Contains(expectedProduct)));
           }
        }
    }
}