using System;

class SumOfNNumbers
{
    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());
        decimal sum = 0.00m;
        decimal number = decimal.MinValue;
        bool IsNumber = number >= -1000 && number <= 1000;
        bool isValid = n >= 1 && n <= 200;
        for (int i = 0; i < n; i++)
        {
            number = decimal.Parse(Console.ReadLine());
            sum += number;
        }
        if (isValid && IsNumber)
        {
            Console.WriteLine(sum);
        }

    }
}
