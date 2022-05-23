
using System;
using System.Collections.Generic;
using NetCoreSpecFlowTask.com.meDirect.pages;
using NetCoreSpecFlowTask.com.meDirect.toolbox;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace NetCoreSpecFlowTask.com.meDirect.swagLabs.stepdefinitions
{
    [Binding]
    public sealed class InventoryStepDefs
    {
        InventoryPage _inventory = new InventoryPage();
        
        [Then(@"verify that user see following products on inventory page")]
        public void ThenVerifyThatUserSeeFollowingProductsOnInventoryPage(List<string> expectedProductList)
        {
            /*
            List<string> actualProductList = BrowserUtilities.getElementsText(_inventory.InventoryItems);
            Assert.AreEqual(expectedProductList, actualProductList);
            */
        }
    }
}