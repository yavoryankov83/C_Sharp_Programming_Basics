using System;

    class FourDigits
    {
        static void Main(string[] args)
        {
        int number = int.Parse(Console.ReadLine());
        int a = number / 1000;
        int b = (number / 100) % 10;
        int c = (number / 10) % 10;
        int d = number % 10;
        int sum = a + b + c + d;
        Console.WriteLine(sum);
        Console.WriteLine(d + "" + c + "" + b + "" + a);
        Console.WriteLine(d + "" + a + "" + b + "" + c);
        Console.WriteLine(a + "" + c + "" + b + "" + d);
    }
    }

