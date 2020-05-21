using TechTalk.SpecFlow;
using System;
using NUnit.Framework;
using RestSharp;
using sampletest.RestApiUtilities;

namespace sampletest.steps.ApiSample
{

    [Binding]
    public class ApiSample
    {
        RestUtilities p1 = new RestUtilities();//created object of class here    

        [Given(@"I know the api deatils")]
        public void GivenPrecondition1()
        {
            Console.WriteLine("Give part ..");
        }

        [When(@"I request get")]
        public void WhenAction1()
        {
            Console.WriteLine("When Some conditions");
            p1.ReturnResponseCode("http://restapi.demoqa.com/utilities/weather/city/", "London");

        }

        [Then(@"I get desired response")]
        public void ThenTestableOutcome1()
        {
            Console.WriteLine("Then some outcome");


            Assert.IsTrue(p1.ValidatePresenceOfText("London"),"expected true but found false");
        }
    }

}

