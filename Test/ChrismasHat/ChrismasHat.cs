using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChrismasHat
{
    class ChrismasHat
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var cols = 4 * n + 1;
            var rows = 2 * n + 5;

            var symbol1 = '/';
            var symbol2 = '|';
            var symbol3 = '\\';

            //first tree rows
            for (int i = 0; i < 3; i++)
            {
                Console.Write(new string('.', (cols - 3) / 2));
                if (i == 1)
                {
                    symbol1 = symbol3;
                    symbol3 = '/';

                }
                else if (i == 2)
                {
                    symbol1 = '*';
                    symbol2 = '*';
                    symbol3 = '*';
                }
                Console.Write(symbol1);
                Console.Write(symbol2);
                Console.Write(symbol3);
                Console.WriteLine(new string('.', (cols - 3) / 2));
            }

            //middle part
            for (int i = 0; i < 2 * n - 1; i++)
            {
                Console.Write(new string('.', (cols - 5) / 2 - i));
                Console.Write('*');
                Console.Write(new string('-', 1 + i));
                Console.Write('*');
                Console.Write(new string('-', 1 + i));
                Console.Write('*');
                Console.WriteLine(new string('.', (cols - 5) / 2 - i));
            }

            //last part
            Console.WriteLine(new string('*', cols));
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write("*.");
            }
            Console.WriteLine("*");
            Console.WriteLine(new string('*', cols));
        }
    }
}
