using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowCalculation.StepDefinitions
{
    [Binding]
    public class CumulativeStepDefinitions
    {
        private List<int> numbers= new List<int>();
        [Given(@"the numbers are")]
        public void GivenTheNumbersAre(Table table)
        {
            Console.WriteLine("Cumulative Sum");
            var data = table.CreateDynamicSet();
            int x=0;
            foreach (var i in data)
            {
                x++;
                Console.WriteLine("Value_{0} : {1}", x,i.N1);
                numbers.Add(i.N1);
            }
        }

        [Then(@"cumulative result")]
        public void ThenCumulativeResult()
        {
            int x = numbers.Sum();
            Console.WriteLine("Result {0}", x);
        }
    }
}
