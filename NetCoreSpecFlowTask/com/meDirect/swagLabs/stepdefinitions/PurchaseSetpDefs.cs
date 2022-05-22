using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetCoreSpecFlowTask.com.meDirect.pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NetCoreSpecFlowTask.com.meDirect.swagLabs.stepdefinitions
{
    [Binding]
    public sealed class PurchaseSetpDefs
    {
        LoginPage _loginPage = new LoginPage();
        InventoryPage _inventory = new InventoryPage();
        SingleProductPage _singleProduct = new SingleProductPage();
        
        [When(@"enters valid credentials")]
        public void WhenEntersValidCredentials(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _loginPage.Login((string)data.UserName, (string)data.Password);
        }


        [Then(@"user select a random product")]
        public void ThenUserSelectARandomProduct()
        {
            _inventory.selectARandomProduct().Click();
        }

        [Then(@"user add the product to the chart")]
        public void ThenUserAddTheProductToTheChart()
        {
            _singleProduct.clickAddToCartButton();
        }
    }
}