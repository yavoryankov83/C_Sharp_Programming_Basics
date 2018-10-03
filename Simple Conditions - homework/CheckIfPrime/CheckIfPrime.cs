using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfPrime
{
    class CheckIfPrime
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            bool isEven = num % 2 == 0;

            if (isEven)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
