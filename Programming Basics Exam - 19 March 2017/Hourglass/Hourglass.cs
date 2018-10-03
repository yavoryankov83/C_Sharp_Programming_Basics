using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hourglass
{
    class Hourglass
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var cols = 2 * n + 1;

            //first rows
            Console.WriteLine(new string('*', cols));
            Console.Write(".*");
            Console.Write(new string(' ', cols - 4));
            Console.WriteLine("*.");

            //first part
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(new string('.', 2 + i));
                Console.Write('*');
                Console.Write(new string('@', (cols - 6) - (2 * i)));
                Console.Write('*');
                Console.WriteLine(new string('.', 2 + i));
            }

            //middle row
            Console.Write(new string('.', n));
            Console.Write('*');
            Console.WriteLine(new string('.', n));

            //last part
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write(new string('.', n - 1 - i));
                Console.Write('*');
                Console.Write(new string(' ', 0 + i));
                Console.Write('@');
                Console.Write(new string(' ', 0 + i));
                Console.Write('*');
                Console.WriteLine(new string('.', n - 1 - i));
            }

            //last rows
            Console.Write(".*");
            Console.Write(new string('@', cols - 4));
            Console.WriteLine("*.");
            Console.WriteLine(new string('*', cols));
        }
    }
}
