using System;
using System.Numerics;

class Calculate3
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger faktN = 1;
        BigInteger faktK = 1;
        BigInteger faktNK = 1;
        BigInteger result = 0;

        if (k > 1 && k < n && n < 100)
        {
            for (int i = 1; i <= n; i++)
            {
                faktN *= i;
            }
            for (int j = 1; j <= k; j++)
            {
                faktK *= j;
            }
            for (int y = 1; y <= n - k; y++)
            {
                faktNK *= y;
            }
            result = faktN / (faktK * faktNK);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("invalid input");
        }
    }
}
