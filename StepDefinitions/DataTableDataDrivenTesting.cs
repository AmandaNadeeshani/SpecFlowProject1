using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class DataTableDataDrivenTestingStepDefinition
    {
        private IWebDriver driver;  

        public DataTableDataDrivenTestingStepDefinition(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Then(@"Enter search keyword in youtube")]
        public void ThenEnterSearchKeywordInYoutube(Table table)
        {
            var serachcriteria= table.CreateSet<searchkeyTestData>();
            foreach (var keyword  in serachcriteria)
            {
                driver.FindElement(By.XPath("//*[name='search_query']")).Clear();
                driver.FindElement(By.XPath("//*[name='search_query']")).SendKeys(keyword.searchkey);

            }
        } 

        public class searchkeyTestData
        {
            public string searchkey { get; set; }

        }
    }


}