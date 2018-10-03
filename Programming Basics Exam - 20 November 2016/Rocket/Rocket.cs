using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rocket
{
    class Rocket
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var wide = 3 * n;

            //first part
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', wide / 2 - 1 - i));
                Console.Write('/');
                Console.Write(new string(' ', 2 * i));
                Console.Write('\\');
                Console.WriteLine(new string('.', wide / 2 - 1 - i));
            }
            //second part
            Console.Write(new string('.', n / 2));
            Console.Write(new string('*', (3 * n) - (n / 2 + n / 2)));
            Console.WriteLine(new string('.', n / 2));

            //third part
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write(new string('.', n / 2));
                Console.Write('|');
                Console.Write(new string('\\', (3 * n) - (n / 2 + n / 2 + 2)));
                Console.Write('|');
                Console.WriteLine(new string('.', n / 2));
            }
            //last part
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('.', n / 2 - i));
                Console.Write('/');
                Console.Write(new string('*', (3 * n) - (n / 2 + n / 2 + 2) + 2 * i));
                Console.Write('\\');
                Console.WriteLine(new string('.', n / 2 - i));
            }
        }
    }
}
