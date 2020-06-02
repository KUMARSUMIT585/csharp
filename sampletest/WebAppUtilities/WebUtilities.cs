using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
namespace sampletest.WebAppUtilities
{
    public class WebUtilities
    {
        //put this below info in the config manager
        IWebDriver driver = new ChromeDriver(@"C:\Users\dtdev\csharp\csharp\sampletest\Drivers"); //<-Add your path

        public void LaunchApp(string url)
        {
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


    }
}