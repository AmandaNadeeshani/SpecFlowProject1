using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class SanaPlatformLoginStepDefinitions
    {
        private IWebDriver driver;

        //write a constructo to get the browser, which will adress the driver object
        public SanaPlatformLoginStepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
        }

       /* [Given(@"open chrome browswe")]
        public void GivenOpenChromeBrowswe(IWebDriver driver)
        {
            //driver =   new ChromeDriver();
           // driver.Manage().Window.Maximize();
        }*/

        [When(@"Enter the URL here")]
        public void WhenEnterTheURLHere()
        {
           driver.Url = "https://staging-platform.sana-commerce.com/Webstore/AllWebstores";
        }

        [Then(@"S=search with testsana(.*)@gmail\.com and (.*)1smStandard@")]
        public void ThenSSearchWithTestsanaGmail_ComAndSmStandard(int p0, int p1)
        {
            // Find the username field and input email
            driver.FindElement(By.XPath("//input[@id='Email']")).SendKeys("testsana200@gmail.com");

            // Click the submit button
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();

            // Find the password field and input password
          driver.FindElement(By.XPath("//input[@id='Password']")).SendKeys("1smStandard@");

            // Find and click the submit button
         driver.FindElement(By.XPath("//button[@type='submit']")).Click();

        }
    }
}
