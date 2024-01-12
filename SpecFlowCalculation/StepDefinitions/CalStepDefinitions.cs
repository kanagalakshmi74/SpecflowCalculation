using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowCalculation.StepDefinitions
{
    [Binding]
    public class CalStepDefinitions
    {
        [Given(@"the first number (.*) and second number (.*)")]
        public void GivenTheFirstNumberAndSecondNumber(int n1, int n2)
        {
            Console.WriteLine("First Number is {0}", n1);
            Console.WriteLine("Second Number is {0}", n2);
        }

        [When(@"adding two numbers")]
        public void WhenAddingTwoNumbers()
        {
            Console.WriteLine("Adding the given numbers");
        }

        [Then(@"result of the addition (.*)")]
        public void ThenResultOfTheAddition(int r)
        {
            Console.WriteLine("Result {0}",r);
        }

        [When(@"substracting two numbers")]
        public void WhenSubstractingTwoNumbers()
        {
            Console.WriteLine("Subtrating the given numbers");
        }

        [Then(@"result of the subtract (.*)")]
        public void ThenResultOfTheSubtract(int r)
        {
            Console.WriteLine("Result {0}", r);
        }

        [Given(@"the numbers (.*), (.*)")]
        public void GivenTheNumbers(int n1, int n2)
        {
            Console.WriteLine("First Number is {0}", n1);
            Console.WriteLine("Second Number is {0}", n2);
        }

        [When(@"Multiply two numbers")]
        public void WhenMultiplyTwoNumbers()
        {
            Console.WriteLine("Multiply the given numbers");
        }

        [Then(@"result of the multiply (.*)")]
        public void ThenResultOfTheMultiply(int r)
        {
            Console.WriteLine("Result {0}", r);
        }

        [Given(@"multiply output (.*) as Dividend subtract output (.*) as the Divisor")]
        public void GivenMultiplyOutputAsDividendSubtractOutputAsTheDivisor(int n1, int n2)
        {
            Console.WriteLine("Dividend {0}", n1);
            Console.WriteLine("Divisor {0}", n2);
        }


        [When(@"dividing")]
        public void WhenDividing()
        {
            Console.WriteLine("Performs Division");
        }

        [Then(@"result of the division (.*)")]
        public void ThenResultOfTheDivision(decimal r)
        {
            Console.WriteLine("Result {0}", r);
        }

    }
}
