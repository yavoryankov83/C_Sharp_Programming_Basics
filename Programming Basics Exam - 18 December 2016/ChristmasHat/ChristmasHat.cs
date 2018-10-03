using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasHat
{
    class ChristmasHat
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var colsWide = 4 * n + 1;
            var rowsWide = 2 * n + 5;

            var symbol1 = '/';
            var symbol2 = '|';
            var symbol3 = '\\';

            //first part

            for (int row = 0; row < 3; row++)
            {
                if (row == 1)
                {
                    symbol1 = symbol3;
                    symbol3 = '/';
                }
                if (row == 2)
                {
                    symbol1 = symbol2 = symbol3 = '*';
                }
                Console.Write(new string('.', (colsWide - 3) / 2));
                Console.Write(symbol1);
                Console.Write(symbol2);
                Console.Write(symbol3);
                Console.WriteLine(new string('.', (colsWide - 3) / 2));

            }

            //middle part

            for (int i = 0; i < rowsWide - 6; i++)
            {
                Console.Write(new string('.', (colsWide - 5) / 2 - i));
                Console.Write('*');
                Console.Write(new string('-', 1 + i));
                Console.Write('*');
                Console.Write(new string('-', 1 + i));
                Console.Write('*');
                Console.WriteLine(new string('.', (colsWide - 5) / 2 - i));
            }

            //last part

            Console.WriteLine(new string('*', colsWide));
            for (int i = 0; i < colsWide / 2; i++)
            {
                Console.Write("*" + ".");
            }
            Console.Write('*');
            Console.WriteLine();
            Console.WriteLine(new string('*', colsWide));
        }
    }
}
