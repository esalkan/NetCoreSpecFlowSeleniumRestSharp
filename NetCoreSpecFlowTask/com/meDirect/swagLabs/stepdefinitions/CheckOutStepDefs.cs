using NetCoreSpecFlowTask.com.meDirect.pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace NetCoreSpecFlowTask.com.meDirect.swagLabs.stepdefinitions
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