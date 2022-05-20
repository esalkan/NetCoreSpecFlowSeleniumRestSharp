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

        [BeforeScenario]
        public void BeforeScenario()
        {
            Driver.getDriver().Manage().Window.Maximize();
            Driver.getDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Driver.killDriver();
        }
    }
}