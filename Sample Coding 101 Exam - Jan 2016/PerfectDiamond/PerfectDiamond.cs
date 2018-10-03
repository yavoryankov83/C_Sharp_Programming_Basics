using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectDiamond
{
    class PerfectDiamond
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            if (n == 1)
            {
                Console.WriteLine(new string(' ', n - 1) + "*" + new string(' ', n - 1));
                return;
            }

            //first row
            Console.WriteLine(new string(' ', n - 1) + "*" + new string(' ', n - 1));

            //first part
            for (int i = 1; i < n; i++)
            {   
                Console.Write(new string(' ', n - 1 - i));

                for (int j = 0; j < i; j++)
                {
                    Console.Write("*-");
                }
                Console.Write("*");
                Console.WriteLine(new string(' ', n - 1 - i));
            }

            //last part
            for (int i = n - 2; i > 0; i--)
            {
                Console.Write(new string(' ', n - 1 - i));
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*-");
                }
                Console.Write("*");
                Console.WriteLine(new string(' ', n - 1 - i));
            }

            //last row
            Console.WriteLine(new string(' ', n - 1) + "*" + new string(' ', n - 1));
        }
    }
}
