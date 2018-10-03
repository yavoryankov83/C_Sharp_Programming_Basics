using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFort
{
    class DrawFort
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var cols = 2 * n;
            var rows = n;
            var leftSide = n / 2;
            var rightSide = leftSide;

            //first row
            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.Write("\\");
            Console.Write(new string('_', 2 * n - (n / 2 + 2 + n / 2 + 2)));
            Console.Write("/");
            Console.Write(new string('^', n / 2));
            Console.WriteLine("\\");

            //first part
            for (int i = 0; i < n - 3; i++)
            {
                Console.Write("|");
                Console.Write(new string(' ', cols - 2));
                Console.WriteLine("|");
            }

            //second row
            Console.Write("|");
            Console.Write(new string(' ', n / 2 + 1));
            Console.Write(new string('_', 2 * n - (n / 2 + 2 + n / 2 + 2)));
            Console.Write(new string(' ', n / 2 + 1));
            Console.WriteLine("|");

            //last row
            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.Write("/");
            Console.Write(new string(' ', 2 * n - (n / 2 + 2 + n / 2 + 2)));
            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.WriteLine("/");
        }
    }
}
