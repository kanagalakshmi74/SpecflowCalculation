
namespace SpecFlowCalculation.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private CalculatorClass _calculatorClass;

        public CalculatorStepDefinitions(CalculatorClass calculatorClass)
        {
            _calculatorClass = calculatorClass;
        }
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            Console.WriteLine("Given first number");
            _calculatorClass.n1 = number;
            Console.WriteLine(_calculatorClass.n1);
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            Console.WriteLine("Given second number");
            _calculatorClass.n2 = number;
            Console.WriteLine(_calculatorClass.n2);
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            Console.WriteLine("Calls Add method");
            _calculatorClass.Add(_calculatorClass.n1, _calculatorClass.n2);
        }
        [Then(@"the result should be")]
        public void ThenTheResultShouldBe()
        {
            Console.WriteLine("Output : {0}", _calculatorClass.addOutput);
            ScenarioContext.Current["addResult"] = _calculatorClass.addOutput;
        }

        [Given(@"the first number (.*) and the second number (.*)")]
        public void GivenTheFirstNumberAndTheSecondNumber(int n1, int n2)
        {
            Console.WriteLine("First Number {0}, Second Number {1}", n1, n2);
            _calculatorClass.n1 = n1;
            _calculatorClass.n2 = n2;
        }

        [When(@"subtracting two numbers")]
        public void WhenSubtractingTwoNumbers()
        {
            Console.WriteLine("Calls Sub method");
            _calculatorClass.Sub(_calculatorClass.n1, _calculatorClass.n2);
        }

        [Then(@"result of the subtract")]
        public void ThenResultOfTheSubtract()
        {
            Console.WriteLine("Output : {0}", _calculatorClass.subOutput);
            ScenarioContext.Current["subResult"] = _calculatorClass.subOutput;
        }
        [When(@"get outputs of add")]
        public void WhenGetOutputsOfAddAndSub()
        {
            Console.WriteLine("Multiply the output of add and sub");
            var a = (int)ScenarioContext.Current["addResult"];
            var b = (int)ScenarioContext.Current["subResult"];
            Console.WriteLine("Addition output : {0}", a);
            Console.WriteLine("Subtraction output : {0}", b);
            _calculatorClass.Multiple(a, b);
        }
        [Then(@"result of multiply")]
        public void ThenResultOfMultiply()
        {
            Console.WriteLine("Output : {0}", _calculatorClass.multipleOutput);
            ScenarioContext.Current["mulResult"] = _calculatorClass.multipleOutput;
        }
        [Given(@"multiply output as Dividend and (.*) as the Divisor")]
        public void GivenMultiplyOutputAsDividendAndAsTheDivisor(int b)
        {
            var a = (int)ScenarioContext.Current["mulResult"];
            Console.WriteLine("Multiplication output as dividend : {0}", a);
            Console.WriteLine("Divisor : {0}", b);
            _calculatorClass.Divide(a, b);
        }
        [Then(@"result of division")]
        public void ThenResultOfDivision()
        {
            Console.WriteLine("Output : {0}", _calculatorClass.divideOutput);
        }


    }
}
