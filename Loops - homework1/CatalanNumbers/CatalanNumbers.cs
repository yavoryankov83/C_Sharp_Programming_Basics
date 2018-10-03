using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            BigInteger factorial2N = 1;
            BigInteger factorialN1 = 1;
            BigInteger factorialN = 1;

            for (int i = 1; i <= 2 * N; i++)
            {
                factorial2N *= i;
            }
            for (int i = 1; i <= N + 1; i++)
            {
                factorialN1 *= i;
            }
            for (int i = 1; i <= N; i++)
            {
                factorialN *= i;
            }
            Console.WriteLine(factorial2N / (factorialN1 * factorialN));
        }
    }
}
