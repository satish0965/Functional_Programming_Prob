using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionalProb
{
    public class LeapYearProb
    {
        public void LeapYear()
        {
            int year;
            Console.WriteLine("Enter a year to check if it is leap year or not");
            year = Convert.ToInt32((Console.ReadLine()));
            if (year % 400 == 0)
                Console.WriteLine("{0} is a leap year.", year);
            else if (year % 100 == 0)
                Console.WriteLine("{0} is not a leap year.", year);
            else if (year % 4 == 0)
                Console.WriteLine("{0} is a leap year.", year);
            else
                Console.WriteLine("{0} is not a leap year.", year);
        }
    }
}
