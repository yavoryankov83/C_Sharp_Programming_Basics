using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidOfNumbers
{
    class PyramidOfNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var num = 1;
            var counter = 1;

            while (num <= n)
            {
                for (int i = 0; i < counter; i++)
                {
                    Console.Write("{0} ", num);
                    num++;
                    if (num > n)
                    {
                        break;
                    }
                }
                counter++;
                Console.WriteLine();
            }

        }
    }
}
