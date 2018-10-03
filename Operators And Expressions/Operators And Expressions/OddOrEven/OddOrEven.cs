using System;

    class OddOrEven
    {
        static void Main(string[] args)
        {
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine(a % 2 == 0 ? "even" + " " + a : "odd" + " " + a);
        }
    }

