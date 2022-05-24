using NetCoreSpecFlowTask.meDirect.com.saucedemo.pages;
using NetCoreSpecFlowTask.meDirect.com.saucedemo.toolbox;
using NUnit.Framework;
using TechTalk.SpecFlow;
/*
 * @author esalkan
 * @vcard https://esalkan.com
 * @project MeDirect - Skill Assessment
 * @type Web & Api Automation 
 * @repo https://github.com/esalkan/AutomationNetCoreSpecFlowSelenium.git
 */
namespace NetCoreSpecFlowTask.meDirect.com.saucedemo.stepdefinitions
{   // This class is used to define the steps for the feature file
    [Binding]
    public sealed class LogOutStepDefs
    {
        // This is the page object for the LogOut page
        InventoryPage _inventory = new InventoryPage();
        
        [When(@"click on hamburger menu")]
        // This method is used to click on the hamburger menu
        public void WhenClickOnHamburgerMenu()
        {
            _inventory.hamburgerMenu.Click();
        }

        [When(@"click on logout button")]
        // This method is used to click on the logout button
        public void WhenClickOnLogoutButton()
        {
            _inventory.logOutBtn.Click();
        }

        [Then(@"user should be in login ""(.*)"" page")]
        // This method is used to verify the user is in the login page
        public void ThenUserShouldBeInLoginPage(string expectedUrl)
        {
            Assert.That(_inventory.GetActualPageUrl().Equals(expectedUrl));
        }

        [When(@"navigate back")]
        // This method is used to navigate back to the previous page
        public void WhenNavigateBack()
        {
            Driver.getDriver().Navigate().Back();
        }
        
    }
}