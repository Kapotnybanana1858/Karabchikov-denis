using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class CalculatorChecker
    {
        public static bool ValidateCalculator(double sum1, double sum2, string operation, double result)
        {
            if (operation == "+")
            {
                return (sum1 + sum2 == result);
            }
            
            if(operation == "-")
            {
                return (sum1 - sum2 == result);

            }
            if (operation == "*")
            {
                return (sum1 * sum2 == result);

            }
            if (operation == "/")
            {
                return (sum1 / sum2 == result);

            }
            return true;
        }
        
    }
}
