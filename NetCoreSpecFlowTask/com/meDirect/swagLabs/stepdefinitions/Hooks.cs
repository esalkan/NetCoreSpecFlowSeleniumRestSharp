using System;
using System.Reflection;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using Gherkin.Ast;
using NetCoreSpecFlowTask.com.meDirect.toolbox;
using TechTalk.SpecFlow;
using Feature = AventStack.ExtentReports.Gherkin.Model.Feature;
using Scenario = AventStack.ExtentReports.Gherkin.Model.Scenario;

namespace NetCoreSpecFlowTask.com.meDirect.stepdefinitions
{
    [Binding]
    public sealed class Hooks
    {
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
        
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        // This hook is called before each scenario
        [BeforeScenario]
        public void BeforeScenario()
        {
            // Maximize the browser window
            Driver.getDriver().Manage().Window.Maximize();
            // Implicit wait of 5 seconds to find an element if it is not found within 5 seconds it will throw an exception
            Driver.getDriver().Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }

        [BeforeTestRun]
        public static void InitializeReport()
        {
            var htmlReporter = new ExtentHtmlReporter("/Users/esalkan/Desktop/projectHub/InterviewTasks/MeDirect/NetCoreSpecFlowTask/NetCoreSpecFlowTask/Reports/AutomationReport.html"); // create html report
            htmlReporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);
        }
        
        [AfterTestRun]
        public static void TearDownReport()
        {
            extent.Flush();
        }
        
        // This hook is called Before the each scenario 
        [BeforeFeature()]
        public static void BeforeFeature()
        {
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
        }

        // This hook is called after each scenario
        [AfterStep()]
        public void InsertReportingSteps()
        {
            // To add the step results into the report
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

            // Get the step text from the feature file
            if (ScenarioContext.Current.TestError == null)
            {
                // For successful steps
                if (stepType == "Given")
                    // Create the test and assign the status as pass
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                // For Pending Steps
                else if (stepType == "When")
                    // Create the test and assign the status as pass
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "And")
                    // Create the test and assign the status as pass
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
                else if (stepType == "Then")
                    // Create the test and assign the status as pass
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text); 
            } else if (ScenarioContext.Current.TestError != null) // For the failed steps
            {
                if (stepType == "Given")
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                else if (stepType == "When")
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                else if (stepType == "And")
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                else if (stepType == "Then")
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message);
            }

            
            // scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
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