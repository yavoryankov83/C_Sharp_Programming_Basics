using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniLogo
{
    class SoftUniLogo
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var rows = 4 * n - 2;
            var cols = 12 * n - 5;
            var symbol = '|';

            //first part
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write(new string('.', (cols - 1) / 2 - (3 * i)));
                Console.Write(new string('#', 1 + i * 6));
                Console.WriteLine(new string('.', (cols - 1) / 2 - (3 * i)));
            }

            //middle part
            for (int i = 0; i < rows - (2 * n + n); i++)
            {
                Console.Write('|');
                Console.Write(new string('.', ((cols - (cols - 6)) / 2) + 3 * i - 1));
                Console.Write(new string('#', cols - 6 - (6 * i)));
                Console.WriteLine(new string('.', ((cols - (cols - 6)) / 2) + 3 * i));
            }

            //last part
            for (int i = 1; i <= n; i++)
            {
                if (i == n)
                {
                    symbol = '@';
                }
                Console.Write(symbol);
                Console.Write(new string('.', (cols - (6 * n + 1)) / 2 - 1));
                Console.Write(new string('#', 6 * n + 1));
                Console.WriteLine(new string('.', (cols - (6 * n + 1)) / 2));
            }
        }
    }
}
