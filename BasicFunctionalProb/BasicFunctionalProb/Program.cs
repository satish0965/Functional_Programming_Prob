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

            int Problem = Convert.ToInt32(Console.ReadLine());
            switch (Problem)
            {
                case 1:
                    FilpCoinProb flipcoinprob = new FilpCoinProb();
                    flipcoinprob.Flip_Percentage();
                    break;

            }
        }
    }
}