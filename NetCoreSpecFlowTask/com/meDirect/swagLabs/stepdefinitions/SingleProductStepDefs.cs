using System;
using NetCoreSpecFlowTask.com.meDirect.pages;
using NetCoreSpecFlowTask.com.meDirect.toolbox;
using NUnit.Framework;
using OpenQA.Selenium;
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


        [Then(@"user navigate single product (.*) page")]
        public void ThenUserNavigateSingleProductPage(string productName)
        {
            Driver.getDriver().FindElement(By.LinkText(productName)).Click();
        }
    }
}