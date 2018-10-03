using System;
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
            int number = int.Parse(Console.ReadLine());
            bool IsPrime = (number > 1);
            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
            {
                Console.WriteLine($"The Number {number} is prime.");
            }
            else
            {
                Console.WriteLine($"The number {number} is not prime.");
            }
        }
    }
}
