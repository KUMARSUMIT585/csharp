using TechTalk.SpecFlow;
using System;
using NUnit.Framework;
using RestSharp;
using sampletest.RestApiUtilities;
using ReportingLibrary;
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
            Console.WriteLine("Give part ..");
            extent1.CreateTest("Sample API test 1");
            //Given I know the api details
            extent1.SetStepStatusPass("Given I know the api details");


        }

        [When(@"I request get")]
        public void WhenAction1()
        {
            Console.WriteLine("When Some conditions");
            p1.ReturnResponseCode("http://localhost:8080/", "greeting");//please update the base uri & detaile duri here
            extent1.SetStepStatusPass("When I request GET");

        }

        [Then(@"I get desired response")]
        public void ThenTestableOutcome1()
        {
            Console.WriteLine("Then some outcome");
            bool bRes = false;
            //please update the search text here accoding to api under test
            //we will have to discuss to check how to approach asserts & test passing and failing decision , I personally go with the boolean approach 
            //keeping the variable failed as long as we have not done the final validations to make it true
            //Assert.IsTrue(p1.ValidatePresenceOfText("Welcome to my rest assured project"),"expected true but found false");
            bRes = p1.ValidatePresenceOfText("Welcome to my rest assured123 project");
            //extent1.CreateTest(TestContext.CurrentContext.Test.Name);
            if (bRes == true)
            {
                extent1.SetStepStatusPass("Then I get desired response");
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

