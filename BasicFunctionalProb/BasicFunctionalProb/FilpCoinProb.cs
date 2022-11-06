using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionalProb
{
    public class FilpCoinProb
    {
        public void Flip_Percentage()
        {
            int Head = 0;
            int Tails = 0;

            Console.WriteLine("Enter the number of times you want to flip the coin: ");
            int Number_Of_Flips = Convert.ToInt32(Console.ReadLine());

            while (Number_Of_Flips <= 0)
            {
                Console.WriteLine("Invalid input, Please inputa a number greater than 0.");
                Console.WriteLine("Please enter again: ");
                Number_Of_Flips = Convert.ToInt32((Console.ReadLine()));
            }
            for (int i = 0; i < Number_Of_Flips; i++)
            {
                Random flip = new Random();
                int Value = flip.Next(0, 2);

                if (Value < 0.5)
                {
                    Head++;
                }
                else
                {
                    Tails++;
                }
            }
            float Head_Percent = (float)Head * 100 / Number_Of_Flips;
            float Tails_Percent = (float)Tails * 100 / Number_Of_Flips;

            Console.WriteLine(Head_Percent + "% of times the result was head. ");
            Console.WriteLine(Tails_Percent + "% of times the result was tails. ");
        }
    }
}