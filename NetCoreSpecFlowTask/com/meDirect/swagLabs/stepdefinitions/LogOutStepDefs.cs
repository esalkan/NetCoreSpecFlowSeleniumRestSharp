using NetCoreSpecFlowTask.com.meDirect.pages;
using NetCoreSpecFlowTask.com.meDirect.toolbox;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace NetCoreSpecFlowTask.com.meDirect.stepdefinitions
{   // This class is used to define the steps for the feature file
    [Binding]
    public sealed class LogOutStepDefs
    {
        // This is the page object for the LogOut page
        ProductsPage _products = new ProductsPage();
        
        [When(@"click on hamburger menu")]
        // This method is used to click on the hamburger menu
        public void WhenClickOnHamburgerMenu()
        {
            _products.hamburgerMenu.Click();
        }

        [When(@"click on logout button")]
        // This method is used to click on the logout button
        public void WhenClickOnLogoutButton()
        {
            _products.logOutBtn.Click();
        }

        [Then(@"user should be in login ""(.*)"" page")]
        // This method is used to verify the user is in the login page
        public void ThenUserShouldBeInLoginPage(string expectedUrl)
        {
            Assert.That(_products.GetActualPageUrl().Equals(expectedUrl));
        }

        [When(@"navigate back")]
        // This method is used to navigate back to the previous page
        public void WhenNavigateBack()
        {
            Driver.getDriver().Navigate().Back();
        }
        
    }
}