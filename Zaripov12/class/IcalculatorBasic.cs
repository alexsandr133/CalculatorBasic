using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CalculatorBasic.BasicCalculator.classes
{
        public class BasicCalculator : IcalculatorBasic
        {
            public double Addition(double value1, double value2)
            {
                return value1 + value2;
            }

            public double Divetion(double value1, double value2)
            {
                return value1 / value2;
            }
            public double Multiplication(double value1, double value2)
            {
                return value1 * value2;
            }
            public double Substraction(double value1, double value2)
            {
                return value1 - value2;
            }
        }
}