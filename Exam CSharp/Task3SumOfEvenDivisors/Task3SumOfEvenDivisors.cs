using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3SumOfEvenDivisors
{
    class Task3SumOfEvenDivisors
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int sumOfEvenDevisors = 0;

            for (int i = A; i <= B; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0 && j % 2 == 0)
                    {
                        sumOfEvenDevisors += j;
                    }
                }
            }
            Console.WriteLine(sumOfEvenDevisors);
        }
    }
}
