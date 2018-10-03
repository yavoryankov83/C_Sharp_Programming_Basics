using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckSum
{
    class CheckSum
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;

            for (int i = 0; i < count; i++)
            {
                int num1 = int.Parse(Console.ReadLine());
                sum1 += num1;
            }
            for (int i = 0; i < count; i++)
            {
                int num2 = int.Parse(Console.ReadLine());
                sum2 += num2;
            }
            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum = {0}", sum1);
            }
            else
            {
                Console.WriteLine("No, diff = {0}", Math.Abs(sum1 - sum2));
            }
        }
    }
}
