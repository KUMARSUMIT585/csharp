using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.IE;
using System;
using System.Configuration;
namespace sampletest.WebAppUtilities
{
    public class WebUtilities
    {
        //put this below info in the config manager
        private static IWebDriver driver;
        //string DriverName = "IE";//make this configurable
        String DriverName=ConfigurationManager.AppSettings["BrowserName"];//from app.config file
        String DriverPath=ConfigurationManager.AppSettings["DriverPath"];
        public IWebDriver SelectBrowserType()
        {
            switch (DriverName)
            {
                case "CHROME":
                    driver = new ChromeDriver(@DriverPath); //<-Add your path
                    //return driver;
                    break;

                case "IE":
                    driver = new InternetExplorerDriver(@DriverPath); //<-Add your path
                    //return driver;
                    break;
          }
            return driver;


        }
        public void LaunchApp(string url)
        {
            SelectBrowserType();
            driver.Navigate().GoToUrl(url);//we need to parameterize this later
        }
        /**
        method returns true if title is same as expected and false otherwiese
        */
        public bool ValidatePageTitle(string text)
        {
            string title = driver.Title;

            if (title.Equals(text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GetPageTitle()
        {
            return driver.Title;

        }


    }
}