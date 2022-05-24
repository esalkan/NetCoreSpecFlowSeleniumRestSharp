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
{
    
    [Binding] // Binds the steps to the class
    // This class contains all the steps for the login page of the application
    public class LoginStepDefs
    {
        // Our page objects are defined here and instantiated in the constructor of the class that contains the step definitions
        LoginPage _loginPage = new LoginPage();

        // Step definitions are defined here and called from the feature file using the [Given] or [When] tags respectively
        [Given(@"navigate to the login page")]
        public void GivenNavigateToTheLoginPage() // Navigates to the login page
        {
            Driver.getDriver().Navigate().GoToUrl("https://www.saucedemo.com/");
            
            
        }

        // Enter the username and password steps 
        [When(@"enter (.*) and (.*) credentials")]
        public void WhenEnterAndCredentials(string userName, string password) 
        {
            _loginPage.Login(userName,password);
        }

        // Click the login button step
        [When(@"click on login button")]
        public void WhenClickOnLoginButton()
        {
            _loginPage.ClickOnLoginBtn(); // calls the method in the page object
        }

        // Verify the inventory page is displayed
        [Then(@"user should be in ""(.*)"" page")]
        public void ThenUserShouldBeInPage(string expectedPageUrl)
        {
            Assert.IsTrue(_loginPage.GetActualPageUrl().Contains(expectedPageUrl)); // Asserts that the actual page url contains the expected page url
        }

        // Verify the error message is displayed
        [Then(@"user should see (.*) error message")]
        public void ThenUserShouldSeeErrorMessage(string errorMessage)
        {
            Assert.IsTrue(_loginPage.GetWrongCredentialErrorMessage().Equals(errorMessage)); // Asserts that the actual error message equals the expected error message
        }

    }
}