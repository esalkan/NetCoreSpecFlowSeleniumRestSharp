using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetCoreSpecFlowTask.com.meDirect.pages;
using NetCoreSpecFlowTask.com.meDirect.toolbox;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace NetCoreSpecFlowTask.com.meDirect.stepdefinitions
{
    [Binding]
    public sealed class LogOutStepDefs
    {
        private InventoryPage _inventory = new InventoryPage();
        
        [When(@"click on hamburger menu")]
        public void WhenClickOnHamburgerMenu()
        {
            _inventory.hamburgerMenu.Click();
        }

        [When(@"click on logout button")]
        public void WhenClickOnLogoutButton()
        {
            _inventory.logOutBtn.Click();
        }

        [Then(@"user should be in login ""(.*)"" page")]
        public void ThenUserShouldBeInLoginPage(string expectedUrl)
        {
            Assert.That(_inventory.GetActualPageUrl().Equals(expectedUrl));
        }

        [When(@"navigate back")]
        public void WhenNavigateBack()
        {
            Driver.getDriver().Navigate().Back();
        }
    }
}