using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger fact2N = 1;
        BigInteger factN1 = 1;
        BigInteger factN = 1;
        BigInteger result = 0;
        
        if (n >= 0 && n <= 100)
        {
            for (int i = 1; i <= 2 * n; i++)
            {
                fact2N *= i;
            }
            for (int j = 1; j <= n + 1; j++)
            {
                factN1 *= j;
            }
            for (int y = 1; y <= n; y++)
            {
                factN *= y;
            }

            result = fact2N / (factN1 * factN);

            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("invalid input");
        }
    }
}
