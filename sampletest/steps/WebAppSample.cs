using TechTalk.SpecFlow;
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using ReportingLibrary;
using sampletest.WebAppUtilities;
using System.Configuration;

namespace sampletest.steps.webtests
{
    [Binding]
    public class WebAppSample
    {
        ExtentReportsHelper extent1=new ExtentReportsHelper();
        WebUtilities webutil=new WebUtilities();
        
        [Given(@"I know the url details")]
        public void GivenPrecondition1()
        {
            extent1.CreateTest("Sample Web App Test 1");
            extent1.SetStepStatusPass("Given I know the url details");        }

        [When(@"I launch the web app in G Chrome")]
        public void WhenAction1()
        {
            webutil.LaunchApp(ConfigurationManager.AppSettings["BaseUrl"]);
            extent1.SetStepStatusPass("When I launch the web app in G Chrome");  
        }

        [Then(@"I get launched web page")]
        public void ThenTestableOutcome1()
        {
            bool result1= webutil.ValidatePageTitle("SpecFlow - Behavior Driven Development for .NET");
            if (result1==true)
            {
                extent1.SetStepStatusPass("Then I get launched web page"); 
            }
            else
            {
                extent1.SetStepStatusFail("Then I get launched web page"); 
                extent1.SetTestStatusFail("The actual page title is not same as the expected page title");
            }
            extent1.Close();            

        }
    }
}