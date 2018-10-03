using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeCheck
{
    class PrimeCheck
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()); //1. read from the console
            int devider = 1;
            int count = 0;

            if (N > 1)
            {
                for (devider = 1; devider <= N; devider++)
                {
                    if (N % devider == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
