using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ButterFly
{
    class ButterFly
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var cols = 2 * n - 1;
            var rows = 2 * (n - 2) + 1;

            var symbol = '*';

            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 != 0)
                {
                    symbol = '-';
                }
                else
                {
                    symbol = '*';
                }
                Console.Write(new string(symbol, n - 2));
                Console.Write("\\ /");
                Console.WriteLine(new string(symbol, n - 2));
            }
            Console.Write(new string(' ', n - 1));
            Console.Write('@');
            Console.WriteLine(new string(' ', n - 1));

            for (int i = 0; i < n - 2; i++)
            {
                if (i % 2 != 0)
                {
                    symbol = '-';
                }
                else
                {
                    symbol = '*';
                }
                Console.Write(new string(symbol, n - 2));
                Console.Write("/ \\");
                Console.WriteLine(new string(symbol, n - 2));
            }
        }
    }
}
