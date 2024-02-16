using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class featureDefinition
    {
        private IWebDriver driver;

        //write a constructo to get the browser, which will adress the driver object
        public featureDefinition(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"open the browser")]
        public void GivenOpenTheBrowser()
        {
             driver =   new ChromeDriver();
             driver.Manage().Window.Maximize();
        }

        [When(@"Enter URL")]
        public void WhenEnterURL()
        {
            driver.Url = "https://www.youtube.com/";
            Thread.Sleep(5000);
        }

        [Then(@"Search for the testers talk")]
        public void ThenSearchForTheTestersTalk()
        {
            driver.FindElement(By.XPath("//*[@name=\"search_query\"]")).SendKeys("Testers talk");
            driver.FindElement(By.XPath("/html/body/ytd-app/div[1]/div/ytd-masthead/div[4]/div[2]/ytd-searchbox/button")).Click();
            Thread.Sleep(5000);

           // driver.Quit();

        }

    }
}