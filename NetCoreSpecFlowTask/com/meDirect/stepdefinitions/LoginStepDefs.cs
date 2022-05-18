using System;
using NetCoreSpecFlowTask.com.meDirect.pages;
using NetCoreSpecFlowTask.com.meDirect.toolbox;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NetCoreSpecFlowTask.com.meDirect.stepdefinitions
{
    [Binding]
    public class LoginStepDefs
    {
        LoginPage _loginPage = new LoginPage();
        
        [Given(@"navigate to the login page")]
        public void GivenNavigateToTheLoginPage()
        {
            Driver.getDriver().Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [Given(@"enter valid credentials")]
        public void GivenEnterValidCredentials(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            _loginPage.fillTheLoginForm((string)data.UserName,(string)data.Password);
        }

        [Given(@"click on login button")]
        public void GivenClickOnLoginButton()
        {
            _loginPage.clickOnLoginBtn();
        }

        [Then(@"user should be in inventory page")]
        public void ThenUserShouldBeInInventoryPage()
        {
            Assert.That(_loginPage.getActualTitle().ToString(), Is.EqualTo("Swag Labs"));
        }
    }
}