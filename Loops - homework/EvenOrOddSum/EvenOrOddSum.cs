using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOddSum
{
    class EvenOrOddSum
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < count; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
            }
            Console.WriteLine(evenSum == oddSum ? $"Yes Sum = {evenSum}" : $"No Diff = {Math.Abs(evenSum - oddSum)}");
        }
    }
}   
