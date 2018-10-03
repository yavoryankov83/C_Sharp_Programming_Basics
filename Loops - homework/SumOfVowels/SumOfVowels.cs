﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfVowels
{
    class SumOfVowels
    {
        static void Main(string[] args)
        {
            var word = Console.ReadLine();
            int vowelsSum = 0;

            foreach (char letter in word)
            {
                switch (letter)
                {
                    case 'a': vowelsSum += 1;
                        break;
                    case 'e':
                        vowelsSum += 2;
                        break;
                    case 'i':
                        vowelsSum += 3;
                        break;
                    case 'o':
                        vowelsSum += 4;
                        break;
                    case 'u':
                        vowelsSum += 5;
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(vowelsSum);
        }
    }
}
