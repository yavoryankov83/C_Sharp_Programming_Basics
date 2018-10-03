using System;
using System.Numerics;

class Maslan
{
    static void Main(string[] args)
    {
        int transformationsCount = 0;

        BigInteger n = BigInteger.Parse(Console.ReadLine());

        while (transformationsCount < 10 && n > 9)
        {
            int oddProduct = 1;

            while (n > 0)
            {
                n /= 10;
                string nString = n.ToString();
                int oddSum = 0;

                for (int i = 1; i <= nString.Length; i += 2)
                {
                    oddSum += nString[i] - '0';
                }
                if (oddSum != 0)
                {
                    oddProduct *= oddSum;
                }
            }
            n = oddProduct;
            transformationsCount++;
        }
        if (transformationsCount < 10)
        {
            Console.WriteLine(transformationsCount);
        }
        else if (transformationsCount > 10)
        {
            throw new Exception("Should not happened");
        }
        Console.WriteLine(n);
    }
}
