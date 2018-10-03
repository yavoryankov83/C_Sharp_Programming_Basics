using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task1BirdsAndFeathers
{
    class Task1BirdsAndFeathers
    {
        static void Main(string[] args)
        {
            BigInteger birds = BigInteger.Parse(Console.ReadLine());
            BigInteger featchers = BigInteger.Parse(Console.ReadLine());

            double average = (double)featchers / (double)birds;

            if (birds % 2 == 0)
            {
                average *= 123123123123;
            }
            else
            {
                average /= 317;
            }
            Console.WriteLine("{0:F4}", average);
        }
    }
}
