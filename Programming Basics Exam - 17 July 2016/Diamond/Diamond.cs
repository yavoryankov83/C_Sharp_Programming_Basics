using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Diamond
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var cols = 5 * n;
            var rows = 3 * n + 2;

            //first row
            Console.Write(new string('.', n));
            Console.Write(new string('*', cols - 2 * n));
            Console.WriteLine(new string('.', n));

            //first part
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string('.', n - 1 - i));
                Console.Write('*');
                Console.Write(new string('.', cols - (2 * n) +  2 * i));
                Console.Write('*');
                Console.WriteLine(new string('.', n - 1 - i));
            }

            //second row
            Console.WriteLine(new string('*', cols));

            //second part
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write(new string('.',1 + i));
                Console.Write('*');
                Console.Write(new string('.', cols - 4 - 2 * i));
                Console.Write('*');
                Console.WriteLine(new string('.', 1 + i));
            }

            //last row
            Console.Write(new string('.', (cols - n + 2) / 2));
            Console.Write(new string('*', n - 2));
            Console.Write(new string('.', (cols - n + 2) / 2));
        }
    }
}
