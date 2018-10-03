using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitSwap
{
    class BitSwap
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            // Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

            for (int i = 0; i < k; i++)
            {
                int maskOne = (int)(number & (1 << p)) >> p;
                int maskTwo = (int)(number & (1 << q)) >> q;

                //mask one
                if (maskOne == 0)
                {
                    number = number & (~(1 << q));
                }
                else if (maskOne == 1)
                {
                    number = number | (1 << q);
                }

                //mask two
                if (maskTwo == 0)
                {
                    number = number & (~(1 << p));
                }
                else if (maskTwo == 1)
                {
                    number = number | (1 << p);
                }

                p++;
                q++;
            }

            Console.WriteLine(number);
        }
    }
}
