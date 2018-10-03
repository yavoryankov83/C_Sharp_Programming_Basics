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

            var stars = '*';
            //first part
            for (int i = 1; i <= 2 * (n - 2) / 2; i++)
            {
                if (i % 2 == 0)
                {
                    stars = '-';
                }
                Console.Write(new string(stars, n - 2));
                Console.Write("\\");
                Console.Write(' ');
                Console.Write("/");
                Console.WriteLine(new string(stars, n - 2));
                stars = '*';
            }
            //middle part
            Console.Write(new string(' ', n - 1));
            Console.Write('@');
            Console.WriteLine(new string(' ', n - 1));
            //last part
            for (int i = 1; i <= 2 * (n - 2) / 2; i++)
            {
                if (i % 2 == 0)
                {
                    stars = '-';
                }
                Console.Write(new string(stars, n - 2));
                Console.Write("/");
                Console.Write(' ');
                Console.Write("\\");
                Console.WriteLine(new string(stars, n - 2));
                stars = '*';
            }
        }
    }
}
