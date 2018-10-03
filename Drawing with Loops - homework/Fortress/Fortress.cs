using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortress
{
    class Fortress
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            //first row
            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.Write("\\");
            Console.Write(new string('_', 2 * n - 2 * (n/2) - 4));
            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.WriteLine("\\");

            //middle
            for (int i = 0; i < n - 3; i++)
            {
                Console.Write("|");
                Console.Write(new string(' ', 2 * n - 2));
                Console.WriteLine("|");
            }
            //row
            Console.Write("|");
            Console.Write(new string(' ', n / 2 + 1));
            Console.Write(new string('_', 2 * n - 2 * (n / 2) - 4));
            Console.Write(new string(' ', n / 2 + 1));
            Console.WriteLine("|");

            //last row
            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.Write("/");
            Console.Write(new string(' ', (2 * n) - (2 * (n / 2) + 4)));
            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.Write("/");
        }
    }
}
