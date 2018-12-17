using System;
using TechTalk.SpecFlow;

namespace SeleniumWithCSharp.Steps
{
    [Binding]
    public class FirstFeatureFileSteps
    {
        [Given(@"Open Browser")]
        public void GivenOpenBrowser()
        {
            //ScenarioContext.Current.Pending();
        }
    }
}
