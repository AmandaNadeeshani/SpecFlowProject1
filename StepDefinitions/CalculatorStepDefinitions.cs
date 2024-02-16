using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        [Given(@"I input the followin numbers to the calculator")]
        public void GivenIInputTheFollowinNumbersToTheCalculator(Table table)
        {
            var data = table.CreateSet<calculation>();

            foreach (var item in data)
            {
                Console.WriteLine($"The number is {item.Numbers}   ");
            }
           
        }
    }

    public record calculation
    {
        public int Numbers
        {
            get; set;
        }

    }
}
