using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenPowersOfTwo
{
    class EvenPowersOfTwo
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var num = 1;

            Console.WriteLine(1);

            for (int i = 0; i < n / 2 ; i++)
            {
                num *= 4;
                Console.WriteLine(num);
            }
        }
    }
}
