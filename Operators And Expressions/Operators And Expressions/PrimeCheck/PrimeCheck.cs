using System;

class PrimeCheck
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if ((n <= 100) && (n >= 2))
        {
            if ((n % n == 0) && (n % 1 == 0))
            {
                Console.WriteLine("true");
            }
        }
        else
        {
            Console.WriteLine("false");
        }


    }
}

