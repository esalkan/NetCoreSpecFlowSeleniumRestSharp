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
    public sealed class CartStepDefs
    {
        CartPage _cart = new CartPage();
        
        [When(@"user click remove the product")]
        public void WhenUserClickRemoveTheProduct()
        {
            _cart.cartRemoveButton.Click();
        }

        [Then(@"user should no longer see item in cart")]
        public void ThenUserShouldNoLongerSeeItemInCart()
        {
            Assert.IsFalse(_cart.removedCartItem.Displayed);
        }
    }
}