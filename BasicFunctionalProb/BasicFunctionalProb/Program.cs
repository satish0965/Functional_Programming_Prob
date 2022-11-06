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
            Console.WriteLine("5 for Factors");
            Console.WriteLine("6 for Quotient and remainder");
            Console.WriteLine("7 for Swap two Number");
            Console.WriteLine("8 for Check even or odd");
            Console.WriteLine("9 for Check Vowels");
            Console.WriteLine("10 for Check Largest of Three Numbers");


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
                case 5:
                    FactorsProb factors = new FactorsProb();
                    factors.Factors();
                    break;
                case 6:
                    QuotientRemainder quotientRemainder = new QuotientRemainder();
                    quotientRemainder.QuotientAndRemainder();
                    break;
                case 7:
                    SwappingNumber swapnumber = new SwappingNumber();
                    swapnumber.SwapTwoNumber();
                    break;
                case 8:
                    CheckEvenorOdd checkevenorodd = new CheckEvenorOdd();
                    checkevenorodd.EvenOrOdd();
                    break;
                case 9:
                    CheckOvels ovels = new CheckOvels();
                    ovels.CheckVowelOrConsonant();
                    break;
                case 10:
                    LargestNumber largestnumber = new LargestNumber();
                    largestnumber.LargestThreeNumbers();
                    break;
            }
        }
    }
}