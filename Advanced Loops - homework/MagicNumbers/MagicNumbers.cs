using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicNumbers
{
    class MagicNumbers
    {
        static void Main(string[] args)
        {
            //var num = int.Parse(Console.ReadLine());

            //for (int a = 1; a <= num; a++)
            //{
            //    for (int b = 1; b <= num; b++)
            //    {
            //        for (int c = 1; c <= num; c++)
            //        {
            //            for (int d = 1; d <= num; d++)
            //            {
            //                for (int e = 1; e <= num; e++)
            //                {
            //                    for (int f = 1; f <= num; f++)
            //                    {
            //                        if (num == a * b * c * d * e * f)
            //                        {
            //                            Console.Write("{0}{1}{2}{3}{4}{5} ", a, b, c, d ,e ,f);
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            var n = int.Parse(Console.ReadLine());

            for (int i = 111111; i <= 999999; i++)
            {
                var num = 1;
                var z = i;

                while (z != 0)
                {
                    int digit = z % 10;
                    z /= 10;
                    num *= digit;
                }
                if (num == n)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
