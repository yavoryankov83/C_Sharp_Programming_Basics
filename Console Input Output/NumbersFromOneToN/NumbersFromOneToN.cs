using System;

    class NumbersFromOneToN
    {
        static void Main(string[] args)
        {
        int n = int.Parse(Console.ReadLine());
        bool isValid = n >= 1 && n <= 1000;
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(isValid ? i.ToString() : "invalid number");
        }
        }
    }
