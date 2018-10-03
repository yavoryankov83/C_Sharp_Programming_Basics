using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Task1MutantSquirrels
{
    class Task1MutantSquirrels
    {
        static void Main(string[] args)
        {
            uint trees = uint.Parse(Console.ReadLine());
            uint branches = uint.Parse(Console.ReadLine());
            uint squirrelsOnBranch = uint.Parse(Console.ReadLine());
            uint averageNumberOfTails = uint.Parse(Console.ReadLine());

            double result = 0;

            BigInteger tails = trees * branches * squirrelsOnBranch * averageNumberOfTails;

            if (tails % 2 == 0)
            {
                result = (double)tails * 376439;
            }
            else
            {
                result = (double)tails / 7;
            }
            Console.WriteLine("{0:F3}", result);
        }
    }
}
