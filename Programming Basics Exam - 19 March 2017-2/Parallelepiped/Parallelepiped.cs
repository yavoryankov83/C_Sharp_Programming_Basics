using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallelepiped
{
    class Parallelepiped
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var rows = 4 * n + 4;
            var cols = 3 * n + 1;

            //first row
            Console.Write('+');
            Console.Write(new string('~', n - 2));
            Console.Write('+');
            Console.WriteLine(new string('.', cols - (2 + n - 2)));

            //first part
            for (int i = 0; i < 2 * n + 1; i++)
            {
                Console.Write('|');
                Console.Write(new string('.', 0 + i));
                Console.Write('\\');
                Console.Write(new string('~', n - 2));
                Console.Write('\\');
                Console.WriteLine(new string('.', 2 * n - i));

            }

            //last part
            for (int i = 0; i < 2 * n + 1; i++)
            {
                Console.Write(new string('.', 0 + i));
                Console.Write('\\');
                Console.Write(new string('.', 2 * n - i));
                Console.Write('|');
                Console.Write(new string('~', n - 2));
                Console.WriteLine('|');
            }

            //last row
            Console.Write(new string('.', cols - (2 + n - 2)));
            Console.Write('+');
            Console.Write(new string('~', n - 2));
            Console.WriteLine('+');
            
        }
    }
}
