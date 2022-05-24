using System.Collections.Generic;
using System.Linq;
using NetCoreSpecFlowTask.meDirect.com.saucedemo.pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
/*
 * @author esalkan
 * @vcard https://esalkan.com
 * @project MeDirect - Skill Assessment
 * @type Web & Api Automation 
 * @repo https://github.com/esalkan/AutomationNetCoreSpecFlowSelenium.git
 */
namespace NetCoreSpecFlowTask.meDirect.com.saucedemo.stepdefinitions
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