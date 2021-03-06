// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace NetCoreSpecFlowTask.Resources.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Login Feature")]
    public partial class LoginFeatureFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "Login.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "resources/features", "Login Feature", "\tUser should be able to login with valid credentials and user should not be able " +
                    "to login with invalid credentialsß", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 10
 #line hidden
#line 11
  testRunner.Given("navigate to the login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login feature with valid users credentials")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        [NUnit.Framework.CategoryAttribute("regression_1")]
        [NUnit.Framework.CategoryAttribute("validLogin")]
        [NUnit.Framework.TestCaseAttribute("standard_user", "secret_sauce", null)]
        [NUnit.Framework.TestCaseAttribute("problem_user", "secret_sauce", null)]
        [NUnit.Framework.TestCaseAttribute("performance_glitch_user", "secret_sauce", null)]
        public void LoginFeatureWithValidUsersCredentials(string userName, string password, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "smoke",
                    "regression_1",
                    "validLogin"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("UserName", userName);
            argumentsOfScenario.Add("Password", password);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login feature with valid users credentials", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 18
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 10
 this.FeatureBackground();
#line hidden
#line 19
  testRunner.When(string.Format("enter {0} and {1} credentials", userName, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 20
  testRunner.And("click on login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
  testRunner.Then("user should be in \"inventory.html\" page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Login feature with invalid users credentials")]
        [NUnit.Framework.CategoryAttribute("smoke")]
        [NUnit.Framework.CategoryAttribute("regression_1")]
        [NUnit.Framework.CategoryAttribute("invalidLogin")]
        [NUnit.Framework.TestCaseAttribute("standard_user", "", "Epic sadface: Password is required", null)]
        [NUnit.Framework.TestCaseAttribute("", "secret_sauce", "Epic sadface: Username is required", null)]
        [NUnit.Framework.TestCaseAttribute("standard_user", "random_pass", "Epic sadface: Username and password do not match any user in this service", null)]
        [NUnit.Framework.TestCaseAttribute("problem_user", "random_pass", "Epic sadface: Username and password do not match any user in this service", null)]
        [NUnit.Framework.TestCaseAttribute("performance_glitch_user", "random_pass", "Epic sadface: Username and password do not match any user in this service", null)]
        [NUnit.Framework.TestCaseAttribute("", "", "Epic sadface: Username is required", null)]
        public void LoginFeatureWithInvalidUsersCredentials(string userName, string password, string errorMessage, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "smoke",
                    "regression_1",
                    "invalidLogin"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("UserName", userName);
            argumentsOfScenario.Add("Password", password);
            argumentsOfScenario.Add("ErrorMessage", errorMessage);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Login feature with invalid users credentials", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 33
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 10
 this.FeatureBackground();
#line hidden
#line 34
  testRunner.When(string.Format("enter {0} and {1} credentials", userName, password), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
  testRunner.And("click on login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
  testRunner.Then(string.Format("user should see {0} error message", errorMessage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
