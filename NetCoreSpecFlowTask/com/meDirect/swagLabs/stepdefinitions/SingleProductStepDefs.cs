using System;
using NetCoreSpecFlowTask.com.meDirect.pages;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace NetCoreSpecFlowTask.com.meDirect.swagLabs.stepdefinitions
{
    [Binding]
    public class SingleProductStepDefs
    {
        SingleProductPage _singleProduct = new SingleProductPage();
        
        [Then(@"verify (.*) name and (.*) description and (.*) price")]
        public void ThenVerifyNameAndDescriptionAndPrice(string name, string description, string price)
        {
            Assert.That(_singleProduct.getSingleProductName(), Is.EqualTo(name));
            Assert.That(_singleProduct.getSingleProductDescription(), Is.EqualTo(description));
            Assert.That(_singleProduct.getSingleProductPrice(), Is.EqualTo(price));
        }
    }
}