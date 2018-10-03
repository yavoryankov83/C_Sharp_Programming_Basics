using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumsStep3
{
    class SumsStep3
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum1 = 0;
            var sum2 = 0;
            var sum3 = 0;
            var count = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                count++;

                for (int j = 1; j <= count; j+= 3)
                {
                    if (count == j)
                    {
                        sum1 += num;
                    }
                }
                for (int j = 2; j <= count; j += 3)
                {
                    if (count == j)
                    {
                        sum2 += num;
                    }
                }
                for (int j = 3; j <= count; j += 3)
                {
                    if (count == j)
                    {
                        sum3 += num;
                    }
                }
            }
            Console.WriteLine("sum1 = {0}", sum1);
            Console.WriteLine("sum2 = {0}", sum2);
            Console.WriteLine("sum3 = {0}", sum3);
        }
    }
}
