using System;

    class SumOfFiveNumbers
    {
        static void Main(string[] args)
        {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int e = int.Parse(Console.ReadLine());
        int sum = a + b + c + d + e;
        bool isValid = (a >= -1000 && a <= 1000) && (b >= -1000 && b <= 1000) && (c >= -1000 && c <= 1000) &&
            (d >= -1000 && d <= 1000) && (e >= -1000 && e <= 1000);

        Console.WriteLine(isValid ? sum.ToString() : "invalid number");
    }
}

