using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEvenSum
{
    class OddOrEvenSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int oddSum = 0;
            int evenSum = 0;
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (i % 2 != 0)
                {
                    oddSum += number;
                }
                else
                {
                    evenSum += number;
                }
            }
            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes Sum = {0}", oddSum);
            }
            else
            {
                Console.WriteLine("No Diff = {0}", Math.Abs(oddSum - evenSum));
            }
        }
    }
}
