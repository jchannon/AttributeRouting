﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.1.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.261
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AttributeRouting.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.1.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Route Conventions")]
    public partial class RouteConventionsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "RouteConventions.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Route Conventions", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line 4
 testRunner.Given("I generate the routes defined in the subject controllers");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating routes using the RestfulRouteConvention")]
        [NUnit.Framework.TestCaseAttribute("Index", "GET", "RestfulRouteConvention", new string[0])]
        [NUnit.Framework.TestCaseAttribute("New", "GET", "RestfulRouteConvention/New", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Create", "POST", "RestfulRouteConvention", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Show", "GET", "RestfulRouteConvention/{id}", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Edit", "GET", "RestfulRouteConvention/{id}/Edit", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Update", "PUT", "RestfulRouteConvention/{id}", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Delete", "GET", "RestfulRouteConvention/{id}/Delete", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Destroy", "DELETE", "RestfulRouteConvention/{id}", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Custom", "GET", "RestfulRouteConvention/Custom", new string[0])]
        public virtual void GeneratingRoutesUsingTheRestfulRouteConvention(string action, string method, string url, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating routes using the RestfulRouteConvention", exampleTags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 7
 testRunner.When(string.Format("I fetch the routes for the RestfulRouteConvention controller\'s {0} action", action));
#line 8
 testRunner.Then(string.Format("the route url is \"{0}\"", url));
#line 9
  testRunner.And("the default for \"controller\" is \"RestfulRouteConvention\"");
#line 10
  testRunner.And(string.Format("the default for \"action\" is \"{0}\"", action));
#line 11
  testRunner.And(string.Format("the route for {0} is constrained to {1} requests", action, method));
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating routes using the RestfulRouteConvention on controllers with a RoutePre" +
            "fix attribute")]
        [NUnit.Framework.TestCaseAttribute("Index", "GET", "Prefix", new string[0])]
        [NUnit.Framework.TestCaseAttribute("New", "GET", "Prefix/New", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Create", "POST", "Prefix", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Show", "GET", "Prefix/{id}", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Edit", "GET", "Prefix/{id}/Edit", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Update", "PUT", "Prefix/{id}", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Delete", "GET", "Prefix/{id}/Delete", new string[0])]
        [NUnit.Framework.TestCaseAttribute("Destroy", "DELETE", "Prefix/{id}", new string[0])]
        public virtual void GeneratingRoutesUsingTheRestfulRouteConventionOnControllersWithARoutePrefixAttribute(string action, string method, string url, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating routes using the RestfulRouteConvention on controllers with a RoutePre" +
                    "fix attribute", exampleTags);
#line 25
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 26
 testRunner.When(string.Format("I fetch the routes for the RestfulRouteConventionPrefix controller\'s {0} action", action));
#line 27
 testRunner.Then(string.Format("the route url is \"{0}\"", url));
#line 28
  testRunner.And("the default for \"controller\" is \"RestfulRouteConventionPrefix\"");
#line 29
  testRunner.And(string.Format("the default for \"action\" is \"{0}\"", action));
#line 30
  testRunner.And(string.Format("the route for {0} is constrained to {1} requests", action, method));
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating routes using the RestfulRouteConvention on actions with an explicit ro" +
            "ute defined")]
        public virtual void GeneratingRoutesUsingTheRestfulRouteConventionOnActionsWithAnExplicitRouteDefined()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating routes using the RestfulRouteConvention on actions with an explicit ro" +
                    "ute defined", ((string[])(null)));
#line 43
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 44
 testRunner.When("I fetch the routes for the RestfulRouteConventionWithExplicitRoute controller\'s I" +
                    "ndex action");
#line 45
 testRunner.Then("the 1st route url is \"RestfulRouteConventionWithExplicitRoute\"");
#line 46
  testRunner.And("the 2nd route url is \"Legacy\"");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Generating routes using the RestfulRouteConvention on actions with an explicit or" +
            "dered route defined")]
        public virtual void GeneratingRoutesUsingTheRestfulRouteConventionOnActionsWithAnExplicitOrderedRouteDefined()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Generating routes using the RestfulRouteConvention on actions with an explicit or" +
                    "dered route defined", ((string[])(null)));
#line 48
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 49
 testRunner.When("I fetch the routes for the RestfulRouteConventionWithExplicitOrderedRoute control" +
                    "ler\'s Index action");
#line 50
 testRunner.Then("the 1st route url is \"RestfulRouteConventionWithExplicitOrderedRoute/Primary\"");
#line 51
  testRunner.And("the 2nd route url is \"RestfulRouteConventionWithExplicitOrderedRoute\"");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
