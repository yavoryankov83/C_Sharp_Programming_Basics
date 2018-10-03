using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfOddDivisors
{
    class SumOfOddDivisors
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = A; i <= B; i++)
            {
                for (int devider = 1; devider <= B; devider +=2)
                {
                    if (i % devider == 0)
                    {
                        sum += devider;
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
