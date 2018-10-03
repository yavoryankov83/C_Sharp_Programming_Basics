using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sums3Numbers
{
    class Sums3Numbers
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            if (a + b == c)
            {
                if (a < b)
                {
                    Console.WriteLine($"{a} + {b} = {c}");
                }
                else
                {
                    Console.WriteLine($"{b} + {b} = {c}");
                }
            }
            else if (a + c == b)
            {
                if (c < a)
                {
                    Console.WriteLine($"{c} + {a} = {b}");
                }
                else
                {
                    Console.WriteLine($"{a} + {c} = {b}");
                }
            }
            else if (b + c == a)
            {
                if (b < c)
                {
                    Console.WriteLine($"{b} + {c} = {a}");
                }
                else
                {
                    Console.WriteLine($"{c} + {b} = {a}");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
