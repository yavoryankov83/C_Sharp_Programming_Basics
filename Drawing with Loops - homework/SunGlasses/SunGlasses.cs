using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunGlasses
{
    class SunGlasses
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            //first row
            Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
            
            //middle rows
            for (int row = 1; row <= n - 2; row++)
            {
                Console.Write("*");
                Console.Write(new string('/', 2 * n - 2));
                Console.Write("*");
                if (row == (n - 1) / 2)
                {
                    Console.Write(new string('|', n));
                }
                else
                {
                    Console.Write(new string(' ', n));
                }
                Console.Write("*");
                Console.Write(new string('/', 2 * n - 2));
                Console.Write("*");
                Console.WriteLine();
            }
            //last row
            Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
        }
    }
}
