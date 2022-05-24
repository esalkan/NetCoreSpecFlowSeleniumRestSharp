using NetCoreSpecFlowTask.meDirect.com.saucedemo.pages;
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
    [Binding]
    public class CheckOutStepDefs
    {
        private CheckOutStepOnePage _checkOutStepOne = new CheckOutStepOnePage();
        
        [Then(@"click on continue button")]
        public void ThenClickOnContinueButton()
        {
            _checkOutStepOne.continueButton.Click();
        }

        [Then(@"user should see the error message ""(.*)""")]
        public void ThenUserShouldSeeTheErrorMessage(string expectedError)
        {
            Assert.AreEqual(expectedError,_checkOutStepOne.errorMessage.Text);
        }

        [Then(@"enter first name ""(.*)""")]
        public void ThenEnterFirstName(string str)
        {
            _checkOutStepOne.inputFirstName.SendKeys(str);
        }
        

        [Then(@"enter last name ""(.*)""")]
        public void ThenEnterLastName(string lastName)
        {
            _checkOutStepOne.inputLastName.SendKeys(lastName);
        }
    }
}