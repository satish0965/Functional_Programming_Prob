﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctionalProb
{
    public class CheckOvels
    {
        public void CheckVowelOrConsonant()
        {
            Console.Write("\tEnter an Alphabet: ");
            char letter = Convert.ToChar(Console.ReadLine());
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                Console.WriteLine("\t{0}: is a vowel", letter);
            }
            else
            {
                Console.WriteLine("\t{0}: is a Consonant", letter);
            }
        }
    }
}
