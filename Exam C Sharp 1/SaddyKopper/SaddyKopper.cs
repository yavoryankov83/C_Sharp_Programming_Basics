using System;
using System.Numerics;

class SaddyKopper
{
    static void Main(string[] args)
    {
        string number = Console.ReadLine();
        int transformation = 0;

        while (number.Length > 1 && transformation < 10)
        {
            BigInteger product = 1;
            while (number.Length > 0)
            {
                number = number.Substring(0, number.Length - 1);
                int sum = 0;

                for (int i = 0; i < number.Length; i += 2)
                {
                    sum += (number[i] - '0');
                }
                product *= sum != 0 ? sum : 1;

            }
            transformation++;
            number = product.ToString();
        }

        if (transformation < 10)
        {
            Console.WriteLine(transformation);
        }
        Console.WriteLine(number);
    }
}
