using NetCoreSpecFlowTask.meDirect.com.saucedemo.pages;
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
    public sealed class PurchaseSetpDefs
    {
        LoginPage _loginPage = new LoginPage();
        InventoryPage _inventory = new InventoryPage();
        SingleProductPage _singleProduct = new SingleProductPage();
        CheckOutStepOnePage _checkOutStepOne = new CheckOutStepOnePage();
        CheckOutStepTwoPage _checkOutStepTwo = new CheckOutStepTwoPage();   
        
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

        [Then(@"navigate to cart page")]
        public void ThenNavigateToCartPage()
        {
            _singleProduct.ShoppingCartBtn();
        }

        [Then(@"click on checkout button")]
        public void ThenClickOnCheckoutButton()
        {
            _singleProduct.CheckOutBtn();
        }

        [Then(@"enter ""(.*)"" first name and ""(.*)"" last name and ""(.*)"" postal code")]
        public void ThenEnterFirstNameAndLastNameAndPostalCode(string firstName, string lastName, string postalCode)
        {
            _checkOutStepOne.fillInformationForm(firstName, lastName, postalCode);
        }

        [Then(@"overview the purchase")]
        public void ThenOverviewThePurchase()
        {
            _checkOutStepOne.continueButton.Click();
        }

        [Then(@"click on finish button")]
        public void ThenClickOnFinishButton()
        {
            _checkOutStepTwo.overViewFinishButton.Click();
        }
    }
}