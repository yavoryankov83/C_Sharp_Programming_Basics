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
            var inside = n / 2;

            Console.Write('/');
            Console.Write(new string('^', n / 2));
            Console.Write('\\');
            Console.Write(new string('_', cols - (4 +  2 * inside)));
            Console.Write('/');
            Console.Write(new string('^', n / 2));
            Console.WriteLine('\\');

            for (int i = 0; i < n - 3; i++)
            {
                Console.Write('|');
                Console.Write(new string(' ', cols - 2));
                Console.WriteLine('|');
            }

            Console.Write('|');
            Console.Write(new string(' ', inside + 1));
            Console.Write(new string('_', cols - (4 + 2 * inside)));
            Console.Write(new string(' ', inside + 1));
            Console.WriteLine('|');

            Console.Write('\\');
            Console.Write(new string('_', n / 2));
            Console.Write('/');
            Console.Write(new string(' ', cols - (4 + 2 * inside)));
            Console.Write('\\');
            Console.Write(new string('_', n / 2));
            Console.WriteLine('/');
        }
    }
}
