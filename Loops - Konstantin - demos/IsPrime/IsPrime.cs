using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrime
{
    class IsPrime
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int possibleDevisor = 2; //isPrime if number is devisiable by 1 and intself, so we start from 2
            bool isPrime = true;

            while (isPrime && possibleDevisor <= Math.Sqrt(number))
            {
                if (number % possibleDevisor == 0)
                {
                    isPrime = false;
                }
                possibleDevisor++;
            }
            Console.WriteLine(isPrime ? "Prime" : "Not prime");
            
        }
    }
}
