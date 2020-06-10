using TechTalk.SpecFlow;
using System;
using NUnit.Framework;
using RestSharp;
using sampletest.RestApiUtilities;
using ReportingLibrary;
using System.Configuration;
//using System.Security;
//using System.Security.Principal;

namespace sampletest.steps.ApiSample
{

    [Binding]
    public class ApiSample
    {
        RestUtilities p1 = new RestUtilities();//created object of class here    
        ExtentReportsHelper extent1 = new ExtentReportsHelper();//created object of class here  



        [Given(@"I know the api details")]
        public void GivenPrecondition1()
        {
            extent1.CreateTest("Sample API test 1");
            extent1.SetStepStatusPass("Given I know the api details");
        }

        [When(@"I request get")]
        public void WhenAction1()
        {   //API endppints should be also configured somewhere
            p1.ReturnResponseCode(ConfigurationManager.AppSettings["BaseURI"] + "/", "greeting");//please update the base uri & detaile duri here
            extent1.SetStepStatusPass("When I request GET");

        }

        [Then(@"I get desired response")]
        public void ThenTestableOutcome1()
        {
            bool bRes = false;
            //please update the search text here accoding to api under test
            //we will have to discuss to check how to approach asserts & test passing and failing decision , I personally go with the boolean approach 
            //keeping the variable failed as long as we have not done the final validations to make it true
            bRes = p1.ValidatePresenceOfText("Welcome to my rest assured project");
            //extent1.CreateTest(TestContext.CurrentContext.Test.Name);
            if (bRes == true)
            {
                extent1.SetStepStatusPass("Then I get desired response");
                extent1.SetTestStatusPass();
            }
            else
            {
                extent1.SetStepStatusFail("Then I get desired response");
                extent1.SetTestStatusFail("The searched text is not present in the response body");
            }

            //extent1.Close();//to flush and close the extent report
        }

        [Given(@"I know the api details2")]
        public void GivenPrecondition2()
        {
            extent1.CreateTest("Sample API test 2");
            extent1.SetStepStatusPass("Given I know the api details");
        }

        [When(@"I request get2")]
        public void WhenAction2()
        {   //API endppints should be also configured somewhere
            p1.ReturnResponseCode(ConfigurationManager.AppSettings["BaseURI"] + "/", "greeting");//please update the base uri & detaile duri here
            extent1.SetStepStatusPass("When I request GET");

        }

        [Then(@"I get desired response2")]
        public void ThenTestableOutcome2()
        {
            bool bRes = false;
            //please update the search text here accoding to api under test
            //we will have to discuss to check how to approach asserts & test passing and failing decision , I personally go with the boolean approach 
            //keeping the variable failed as long as we have not done the final validations to make it true
            bRes = p1.ValidatePresenceOfText("Welcome to my rest assured project");
            //extent1.CreateTest(TestContext.CurrentContext.Test.Name);
            if (bRes == true)
            {
                extent1.SetStepStatusPass("Then I get desired response");
                extent1.SetTestStatusPass();
            }
            else
            {
                extent1.SetStepStatusFail("Then I get desired response");
                extent1.SetTestStatusFail("The searched text is not present in the response body");
            }

            extent1.Close();//to flush and close the extent report
        }
    }

}

