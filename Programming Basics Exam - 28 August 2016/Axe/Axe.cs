using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axe
{
    class Axe
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var wide = 5 * n;

            //first part
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('-', 3 * n));
                Console.Write('*');
                Console.Write(new string('-', 0 + i));
                Console.Write('*');
                Console.WriteLine(new string('-', wide - (3 * n + 2) - i));
            }

            //second part
            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('*', 3 * n + 1));
                Console.Write(new string('-', (wide - 3 * n - 1) / 2));
                Console.Write('*');
                Console.WriteLine(new string('-', (wide - 3 * n - 1) / 2));
            }

            //third part
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.Write(new string('-', 3 * n - i));
                Console.Write('*');
                Console.Write(new string('-', (wide - 3 * n - 1) / 2 + 2 * i));
                Console.Write('*');
                Console.WriteLine(new string('-', (wide - 3 * n - 1) / 2 - i));
            }

            //last row
            if (n % 2 == 0)
            {
                Console.Write(new string('-', wide - (2 * n - 1 + n / 2)));
                Console.Write(new string('*', 2 * n - 1));
                Console.WriteLine(new string('-', n / 2));
            }
            else
            {
                Console.Write(new string('-', wide - (2 * n - 2 + n / 2 + 1)));
                Console.Write(new string('*', 2 * n - 2));
                Console.WriteLine(new string('-', n / 2 + 1));
            }
            
        }
    }
}
