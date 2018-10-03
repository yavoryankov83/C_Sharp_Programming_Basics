﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            bool isPrime = true;

            if (n < 2)
            {
                isPrime = false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }
            }
            Console.WriteLine(isPrime ? "Prime" : "Not Prime");
        }
    }
}