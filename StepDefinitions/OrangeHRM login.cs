using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class OrangeHRMuserLogin
    {
        private IWebDriver driver;  

        public OrangeHRMuserLogin(IWebDriver driver)
        {
            this.driver = driver;
        }


        [When(@"Enter the orangeHRM URL")]
        public void WhenEnterTheRangeHRMURL()
        {
            driver.Url = "https://www.youtube.com/";
            Thread.Sleep(5000);
        }

        [Then(@"search with (.*) and (.*)")]
        public void ThenSearchWith(string username, string password)
   
        {
            // Use the 'username' and 'password' parameters directly.
            driver.FindElement(By.XPath("//input[@name='username']")).SendKeys(username);
            driver.FindElement(By.XPath("//input[@name='password']")).SendKeys(password);
            driver.FindElement(By.XPath("//button[@type='submit']")).Click();
            Thread.Sleep(5000);

        }


    }




}