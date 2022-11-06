using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionalProb
{
    public class Harmonic
    {
        public void HarmonicNum()
        {
            Console.Write("\tEnter the number to find Harmonic number : ");
            double num = Convert.ToDouble(Console.ReadLine());
            double harmonicSum = 0.0;
            for (double i = 1; i <= num; i++)
            {
                Console.Write("\t1/{0}  +", i);
                harmonicSum += (1 / i);
            }
            Console.WriteLine("\n\tThe Sum of harmonic number upto {0} is: {1} ", num, harmonicSum);

        }
    }
}
