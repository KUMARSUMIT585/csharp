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
        ExtentReportsHelper extent1 = new ExtentReportsHelper();
        WebUtilities webutil = new WebUtilities();
        JsonReader json = new JsonReader();//for test data reader

        [Given(@"the guest user knows the url details of Scottish Widows")]
        public void GivenPrecondition1()
        {
            extent1.CreateTest("Validate launch of Scottish Widows Home Page");
            extent1.SetStepStatusPass("GIVEN the guest user knows the url details of Scottish Widows");
        }

        [When(@"the guest user launches the web app in a browser")]
        public void WhenAction1()
        {
            webutil.LaunchApp(ConfigurationManager.AppSettings["BaseUrl"]);
            extent1.SetStepStatusPass("WHEN the guest user launches the web app in a browser");
        }

        [Then(@"the guest user should be able to see the Scottish Widows Home Page")]
        public void ThenTestableOutcome1()
        {   //test data has to be parametersied 

            //string expectedTitle="Scottish Widows | Pensions | Life insurance | Investments1";
            //have to think something about test data record & steps mapping class
            string expectedTitle = json.GetTestDataValue(1, "ExpectedPageTitle");
            bool result1 = webutil.ValidatePageTitle(expectedTitle);
            if (result1 == true)
            {
                extent1.SetStepStatusPass("THEN the guest user should be able to see the Scottish Widows Home Page");
                extent1.SetTestStatusPass();
            }
            else
            {
                extent1.SetStepStatusFail("THEN the guest user should be able to see the Scottish Widows Home Page");
                extent1.SetTestStatusFail("The actual page title: '" + webutil.GetPageTitle() + "' is not same as the expected page title:'" + expectedTitle + "' ");
            }
            extent1.Close();

        }
    }
}