using System.Security.Policy;
using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        private readonly Calculator _calculator = new Calculator();
        private int _result;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int firstNumber)
        {
            _scenarioContext["firstNumber"] = firstNumber;
            
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int secondNumber)
        {
            _scenarioContext["secondNumber"] = secondNumber;
        }


        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            var firstNumber = _scenarioContext.Get<int>("firstNumber");
            var secondNumber = _scenarioContext.Get<int>("secondNumber");
            Calculator calculator = new Calculator();

            var result = calculator.Add(firstNumber, secondNumber);
            _scenarioContext["result"] = result;

        }
        [When("the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            var firstNumber = _scenarioContext.Get<int>("firstNumber");
            var secondNumber = _scenarioContext.Get<int>("secondNumber");
            Calculator calculator = new Calculator();

            var result = calculator.Subtraction(firstNumber, secondNumber);
            _scenarioContext["result"] = result;

        }
        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            var firstNumber = _scenarioContext.Get<int>("firstNumber");
            var secondNumber = _scenarioContext.Get<int>("secondNumber");
            Calculator calculator = new Calculator();

            var result = calculator.Multiplication(firstNumber, secondNumber);
            _scenarioContext["result"] = result;
        }
        [When(@"operation (.*) is done to the number (.*)")]
        public void WhenOperationIsDoneToTheNumber(string operand, int number)
        {

            var firstNumber = _scenarioContext.Get<int>("firstNumber");
            Calculator calculate = new Calculator();

            var result = calculate.CheckSymbol(firstNumber, number, operand);
            _scenarioContext["firstNumber"] = result;
            _scenarioContext["result"] = result;

        }
        
        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int valueExpected)
        {
            var result1 = _scenarioContext.Get<int>("result");

            result1.Should().Be(valueExpected);
        }
    }

}