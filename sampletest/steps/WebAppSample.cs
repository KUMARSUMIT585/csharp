using TechTalk.SpecFlow;
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using ReportingLibrary;
using sampletest.WebAppUtilities;

namespace sampletest.steps.webtests
{
    [Binding]
    public class WebAppSample
    {
        ExtentReportsHelper extent1=new ExtentReportsHelper();
        WebUtilities webutil=new WebUtilities();
        //IWebDriver driver = new ChromeDriver(@"C:\Users\dtdev\csharp\csharp\sampletest\Drivers"); //<-Add your path
        
        //extent reports code
        
        //end of extent related codes
        [Given(@"I know the url details")]
        public void GivenPrecondition1()
        {
            Console.WriteLine("Fetching the URL to be launched");
            //!Make sure to add the path to where you extracting the chromedriver.exe:
            //driver.Navigate().GoToUrl("https://google.com");
           
            extent1.CreateTest("Sample Web App Test 1");
            extent1.SetStepStatusPass("Given I know the url details");        }

        [When(@"I launch the web app in G Chrome")]
        public void WhenAction1()
        {
            Console.WriteLine("Trying to launch the web page ");
            //driver.Navigate().GoToUrl("https://specflow.org/");//we need to parameterize this later
             webutil.LaunchApp("https://specflow.org/");
            extent1.SetStepStatusPass("When I launch the web app in G Chrome");  
        }

        [Then(@"I get launched web page")]
        public void ThenTestableOutcome1()
        {
            Console.WriteLine("Then some outcome");
            //IWebElement titleText=driver.FindElement(By.XPath("//*[@id="header_main"]/div/div/span/a/img"));
            //String title=driver.Title;
            bool result1= webutil.ValidatePageTitle("SpecFlow - Behavior Driven Development for .NET");
            //Assert.IsTrue(result1,"The title of web page is :   "+title);
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