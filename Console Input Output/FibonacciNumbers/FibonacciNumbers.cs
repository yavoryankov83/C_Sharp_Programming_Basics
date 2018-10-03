using System;

class FibonacciNumbers
{
    static void Main(string[] args)
    {
        long length = long.Parse(Console.ReadLine());

        long a = 0;
        long b = 1;
        long c = 1;

        Console.Write("0 ");
        Console.Write("1 ");

        for (long i = 0; i < length; i++)
        {
            a = b;
            b = c;
            c = a + b;
            Console.Write(c + " ");
        }

        Console.WriteLine();
    }
}
