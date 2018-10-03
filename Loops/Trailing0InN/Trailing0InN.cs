using System;
using System.Numerics;

class Trailing0InN
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;
        int zeros = 0;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        while(factorial % 10 == 0)
        {
            zeros++;
            factorial /= 10;
        }
        Console.WriteLine("Trailing Zeroes: {0}", zeros);
    }
}
