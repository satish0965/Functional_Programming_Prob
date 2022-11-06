using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionalProb
{
    public class QuotientRemainder
    {
        public void QuotientAndRemainder()
        {
            Console.Write("\tEnter the Dividend: ");
            double dividend = Convert.ToDouble(Console.ReadLine());
            Console.Write("\tEnter the Divisor: ");
            double divisor = Convert.ToDouble(Console.ReadLine());
            double quotient = dividend / divisor;
            double remainder = dividend % divisor;
            Console.WriteLine("\tQuotient is : " + quotient);
            Console.WriteLine("\tRemainder is : " + remainder);
        }

    }
}
