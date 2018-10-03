using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareSums
{
    class CompareSums
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum1 = 0;
            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                sum1 += numbers;
            }

            int sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                sum2 += numbers;
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum = {0}", sum1);
            }
            else
            {
                Console.WriteLine("No, diff = {0})", Math.Abs(sum1 - sum2);
            }
        }
    }
}
