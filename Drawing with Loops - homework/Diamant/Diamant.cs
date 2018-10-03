using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamant
{
    class Diamant
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dashesCount = n / 2;
            var iterations = n / 2;
            var middleDashCount = 0;

            if (n == 1)
            {
                Console.WriteLine("*");
                return;
            }

            if (n % 2 == 1)
            {
                //first part
                Console.WriteLine(
                      new string('-', dashesCount)
                    + new string('*', 1)
                    + new string('-', dashesCount));

                middleDashCount++;
            }

            //middle part
            for (int i = 0; i < iterations; i++)
            {
                Console.WriteLine(
                      new string('-', dashesCount - 1 - i)
                    + new string('*', 1)
                    + new string('-', middleDashCount + 2 * i)
                    + new string('*', 1)
                    + new string('-', dashesCount - 1 - i));
            }

            for (int i = 0; i < iterations - 1; i++)
            {
                Console.WriteLine(new string('-', 1 + i)
                    + new string('*', 1) 
                    + new string('-', n - 4 - 2 * i)
                    + new string('*', 1)
                    + new string('-', 1 + i));
            }

            if (n % 2 == 1)
            {
                //last part
                Console.WriteLine(
                      new string('-', dashesCount)
                    + new string('*', 1)
                    + new string('-', dashesCount));
            }
        }
    }
}
