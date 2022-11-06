// See https://aka.ms/new-console-template for more information
using System;

namespace BasicFunctionalProb

{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welocme to Basic Functional Programming Problems");
            Console.WriteLine("1 for Flip coin and print percentage of Heads and tails");
            Console.WriteLine("2 for Leap Year");
            Console.WriteLine("3 for Power of two");
            Console.WriteLine("4 for Harmonic Number");


            int Problem = Convert.ToInt32(Console.ReadLine());
            switch (Problem)
            {
                case 1:
                    FilpCoinProb flipcoinprob = new FilpCoinProb();
                    flipcoinprob.Flip_Percentage();
                    break;
                case 2:
                    LeapYearProb leapyearprob = new LeapYearProb();
                    leapyearprob.LeapYear();
                    break;
                case 3:
                    PowerOfTwo poweroftwo = new PowerOfTwo();
                    poweroftwo.Power2();
                    break;
                case 4:
                    Harmonic harmonic = new Harmonic();
                    harmonic.HarmonicNum();
                    break;
            }
        }
    }
}