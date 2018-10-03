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
                Console.Write(new string(' ', (2 * n - 2) / 2));
                Console.Write('*');
                Console.WriteLine(new string(' ', (2 * n - 2) / 2));
                return;
            }
            //first row
            Console.Write(new string(' ', (2 * n - 2) / 2));
            Console.Write('*');
            Console.WriteLine(new string(' ', (2 * n - 2) / 2));

            //first part
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string(' ', n - 2 - i));
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*-");
                }
                Console.Write('*');
                Console.WriteLine(new string(' ', n - 2 - i));
            }

            //last part
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(new string(' ', 1 + i));
                for (int j = 0; j < n - 2 - i; j++)
                {
                    Console.Write("*-");
                }
                Console.Write('*');
                Console.WriteLine(new string(' ', 1 + i));
            }

            //last row
            Console.Write(new string(' ', (2 * n - 2) / 2));
            Console.Write('*');
            Console.WriteLine(new string(' ', (2 * n - 2) / 2));
        }
    }
}
