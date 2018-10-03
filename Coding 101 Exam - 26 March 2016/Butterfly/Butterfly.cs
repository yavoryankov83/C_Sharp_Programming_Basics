using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Butterfly
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var cols = 2 * n - 1;
            var rows = 2 * (n - 2) + 1;
            var left = n - 1;
            var right = left;

            var symbol = '*';

            //first part
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
                Console.Write("\\");
                Console.Write(" ");
                Console.Write("/");
                Console.WriteLine(new string(symbol, n - 2));
            }

            //middle part
            Console.Write(new string(' ', left));
            Console.Write("@");
            Console.WriteLine(new string(' ', right));

            //last part
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
                Console.Write("/");
                Console.Write(" ");
                Console.Write("\\");
                Console.WriteLine(new string(symbol, n - 2));
            }
        }
    }
}
