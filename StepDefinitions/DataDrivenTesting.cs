using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class DataDrivenTestingStepDefinition
    {
        private IWebDriver driver;  

        public DataDrivenTestingStepDefinition(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Then(@"Searh for '([^']*)'")]
        public void ThenSearhFor(string searchkey)
        {

            driver.FindElement(By.XPath("//*[@name=\"search_query\"]")).SendKeys(searchkey);
            driver.FindElement(By.XPath("/html/body/ytd-app/div[1]/div/ytd-masthead/div[4]/div[2]/ytd-searchbox/button")).Click();
            Thread.Sleep(5000);

            // driver.Quit();

        }
    }

    
}