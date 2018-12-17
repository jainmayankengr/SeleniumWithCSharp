using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using System.Threading;

namespace SeleniumWithCSharp.Steps
{
    [Binding]
    public class FirstFeatureFileSteps
    {
        IWebDriver driver;
        IWebDriver driver1;
        [Given(@"Open Browser")]
        public void GivenOpenBrowser()
        {
            //ScenarioContext.Current.Pending();
            driver = new ChromeDriver(@"C:\SeleniumWithCSharp\ThirdParty\chrome");
            driver1 = new ChromeDriver(@"C:\SeleniumWithCSharp\ThirdParty\chrome");
            driver.Url = "http://www.facebook.com";
            driver1.Url = "http://www.yahoo.com";
            Thread.Sleep(5000);

            driver.Close();
            driver1.Quit();

        }
    }
}
