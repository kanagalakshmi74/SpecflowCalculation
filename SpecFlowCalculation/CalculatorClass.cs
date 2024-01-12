using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowCalculation
{
    public class CalculatorClass
    {
        public int n1 {  get; set; }
        public int n2 { get; set; }
        public int addOutput { get; set; }
        public int subOutput { get; set; }
        public int multipleOutput { get; set; }
        public decimal divideOutput { get; set; }

        public int Add(int num1,int num2)
        {
            addOutput=num1+num2;
            return addOutput;
        }

        public int Sub(int num1, int num2)
        {
            subOutput = num1 - num2;
            return subOutput;
        }
        public int Multiple(int num1, int num2)
        {            
            multipleOutput = num1 * num2;
            return multipleOutput;
        }
        public decimal Divide(int num1, int num2)
        {
            divideOutput = num1 / num2;
            return divideOutput;
        }
    }
}
