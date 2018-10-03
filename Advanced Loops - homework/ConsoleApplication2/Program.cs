using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 111111; i <= 999999; i++)
            {
                var num = 1;
                var z = i;

                while (z != 0)
                {
                    int digit = z % 10;
                    z /= 10;
                    num *= digit;
                }
                if (num == n)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
