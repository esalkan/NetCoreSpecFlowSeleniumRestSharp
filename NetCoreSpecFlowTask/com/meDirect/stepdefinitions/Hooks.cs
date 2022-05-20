using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NetCoreSpecFlowTask.com.meDirect.toolbox;
using TechTalk.SpecFlow;

namespace NetCoreSpecFlowTask.com.meDirect.stepdefinitions
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        // This hook is called before each scenario
        [BeforeScenario]
        public void BeforeScenario()
        {
            // Maximize the browser window
            Driver.getDriver().Manage().Window.Maximize();
            // Implicit wait of 5 seconds to find an element if it is not found within 5 seconds it will throw an exception
            Driver.getDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        // After each scenario is run this hook is called 
        [AfterScenario]
        public void AfterScenario()
        {
            // Close the browser after each scenario
            Driver.killDriver();
        }
    }
}