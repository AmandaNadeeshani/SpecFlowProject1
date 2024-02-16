using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class ExampleDataDrivenTestingStepDefinition
    {
        private IWebDriver driver;  

        public ExampleDataDrivenTestingStepDefinition(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Then(@"Searh with (.*)")]
        public void ThenSearhWithSpecflowByTestersTalk(string searchkey)
        {
            driver.FindElement(By.XPath("//*[@name=\"search_query\"]")).SendKeys(searchkey);
            driver.FindElement(By.XPath("/html/body/ytd-app/div[1]/div/ytd-masthead/div[4]/div[2]/ytd-searchbox/button")).Click();
            Thread.Sleep(5000);
        }


    }


}