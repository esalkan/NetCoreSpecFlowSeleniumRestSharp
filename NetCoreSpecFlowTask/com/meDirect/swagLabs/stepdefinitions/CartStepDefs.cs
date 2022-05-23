using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetCoreSpecFlowTask.com.meDirect.pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace NetCoreSpecFlowTask.com.meDirect.swagLabs.stepdefinitions
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