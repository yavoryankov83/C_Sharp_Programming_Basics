using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleWithStars
{
    class RectangleWithStars
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            //first row
            Console.WriteLine(new string('%', 2 * n));

            //middle part
            var m = n;
            if (m % 2 == 0)
            {
                m = m - 1;
            }
            for (int i = 0; i < m; i++)
            {
                Console.Write('%');
                if (i == m / 2)
                {
                    Console.Write(new string(' ', (2 * n - 4) / 2));
                    Console.Write("**");
                    Console.Write(new string(' ', (2 * n - 4) / 2));
                }
                else
                {
                    Console.Write(new string(' ', 2 * n - 2));
                }
                Console.WriteLine('%');
            }

            //last row
            Console.WriteLine(new string('%', 2 * n));
        }
    }
}
