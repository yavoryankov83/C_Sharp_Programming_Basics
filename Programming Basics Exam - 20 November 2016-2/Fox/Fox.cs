using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fox
{
    class Fox
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var wide = 2 * n + 3;

            //first part
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('*', 1 + i));
                Console.Write('\\');
                Console.Write(new string('-', wide - (4 + 2 * i)));
                Console.Write('/');
                Console.WriteLine(new string('*', 1 + i));
            }
            //middle part
            for (int i = 0; i < n / 3; i++)
            {
                Console.Write('|');
                Console.Write(new string('*', n / 2 + i));
                Console.Write('\\');
                Console.Write(new string('*', wide - (4 + n / 2 + i + n / 2 + i)));
                Console.Write('/');
                Console.Write(new string('*', n / 2 + i));
                Console.WriteLine('|');
            }
            //last part
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('-', 1 + i));
                Console.Write('\\');
                Console.Write(new string('*', wide - (4 + 2 * i)));
                Console.Write('/');
                Console.WriteLine(new string('-', 1 + i));
            }
        }
    }
}
