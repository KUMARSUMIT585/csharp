using TechTalk.SpecFlow;
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace sampletest.steps.webtests
{
    [Binding]
    public class WebAppSample
    {
        IWebDriver driver = new ChromeDriver(@"C:\Users\dtdev\csharp\csharp\sampletest\Drivers"); //<-Add your path
        //extent reports code
        
        //end of extent related codes
        [Given(@"I know the url deatils")]
        public void GivenPrecondition1()
        {
            Console.WriteLine("Fetching the URL to be launched");
            //!Make sure to add the path to where you extracting the chromedriver.exe:
            //driver.Navigate().GoToUrl("https://google.com");

        }

        [When(@"I launch the web app in G Chrome")]
        public void WhenAction1()
        {
            Console.WriteLine("Trying yo launch the web page ");
            driver.Navigate().GoToUrl("https://specflow.org/");//we need to parameterize this later

        }

        [Then(@"I get aunched web page")]
        public void ThenTestableOutcome1()
        {
            Console.WriteLine("Then some outcome");
            //IWebElement titleText=driver.FindElement(By.XPath("//*[@id="header_main"]/div/div/span/a/img"));
            String title=driver.Title;
            bool result1= false;
            if (title.Equals("SpecFlow - Behavior Driven Development for .NET"))//need to parameterize this later
            {
                result1=true;               
            }
            else{
                result1=false;
            }
            Assert.IsTrue(result1,"The title of web page is :   "+title);
            

        }
    }
}