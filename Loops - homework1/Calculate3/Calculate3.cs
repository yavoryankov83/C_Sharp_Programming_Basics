using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Calculate3
{
    class Calculate3
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            BigInteger factorialNK = 1;

            for (int i = 1; i <= N; i++)
            {
                factorialN *= i;
            }
            for (int i = 1; i <= K; i++)
            {
                factorialK *= i;
            }
            for (int i = 1; i <= N - K; i++)
            {
                factorialNK *= i;
            }
            Console.WriteLine(factorialN / (factorialK * factorialNK));


        }
    }
}
