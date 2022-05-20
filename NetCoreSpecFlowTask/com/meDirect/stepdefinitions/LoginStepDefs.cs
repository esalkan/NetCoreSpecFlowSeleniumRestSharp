using NetCoreSpecFlowTask.com.meDirect.pages;
using NetCoreSpecFlowTask.com.meDirect.toolbox;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace NetCoreSpecFlowTask.com.meDirect.stepdefinitions
{
    [Binding]
    public class LoginStepDefs
    {
        // Anti-context injection code -- 100% wrong
        LoginPage _loginPage = new LoginPage();
        InventoryPage _inventory = new InventoryPage();

        [Given(@"navigate to the login page")]
        public void GivenNavigateToTheLoginPage()
        {
            Driver.getDriver().Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [When(@"enter (.*) and (.*) credentials")]
        public void WhenEnterAndCredentials(string userName, string password)
        {
            _loginPage.Login(userName,password);
        }

        [When(@"click on login button")]
        public void WhenClickOnLoginButton()
        {
            _loginPage.ClickOnLoginBtn();
        }

        [Then(@"user should be in ""(.*)"" page")]
        public void ThenUserShouldBeInPage(string expectedPageUrl)
        {
            Assert.IsTrue(_loginPage.GetActualPageUrl().Contains(expectedPageUrl));
        }

        [Then(@"user should see ""(.*)"" error message")]
        public void ThenUserShouldSeeErrorMessage(string expectedError)
        {
            Assert.IsTrue(_loginPage.GetWrongCredentialErrorMessage().Equals(expectedError));
        }
    }
}