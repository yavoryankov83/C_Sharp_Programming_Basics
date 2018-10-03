using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CalculateAgain
{
    class CalculateAgain
    {
        static void Main(string[] args)
        {
            long N = long.Parse(Console.ReadLine());
            long K = long.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            for (int i = 1; i <= N; i++)
            {
                 factorialN *= i;
            }
            for (int i = 1; i <= K; i++)
            {
                factorialK *= i;
            }
            Console.WriteLine(factorialN / factorialK);
        }
    }
}
