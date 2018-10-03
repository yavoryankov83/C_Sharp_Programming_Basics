using System;

class ThreeNumbers
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        double result = (a + b + c) / 3.0;

        //int max = a;
        //if (b > a)
        //{
        //    max = b;
        //}
        //if (c > a)
        //{
        //    max = c;
        //}
        //Console.WriteLine(max);

        //int min = a;
        //if (b < a)
        //{
        //    min = b;
        //}
        //if (c < a)
        //{
        //    min = c;
        //}
        //Console.WriteLine(min);

        Console.WriteLine(Math.Max(c, (Math.Max(a, b))));
        Console.WriteLine(Math.Min(c, (Math.Min(a, b))));
        Console.WriteLine("{0:F2}", result);

    }
}
