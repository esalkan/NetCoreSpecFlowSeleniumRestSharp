using NetCoreSpecFlowTask.meDirect.com.saucedemo.pages;
using NetCoreSpecFlowTask.meDirect.com.saucedemo.toolbox;
using NUnit.Framework;
using OpenQA.Selenium;
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