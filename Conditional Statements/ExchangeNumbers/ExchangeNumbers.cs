using System;

class ExchangeNumbers
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        bool isValid = a > -100 && a < 100 && b > -100 && b < 100;

        if (a > b && isValid)
        {
            a += b;
            b = a - b;
            a = a - b;
            Console.WriteLine(a + " " + b);
        }
        else if (a <= b && isValid)
        {
            Console.WriteLine(a + " " + b);
        }

    }
}
