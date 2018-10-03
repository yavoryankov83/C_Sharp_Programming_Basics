using System;

class Printing
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int s = int.Parse(Console.ReadLine());
        double p = double.Parse(Console.ReadLine());

        double result = (n * s) / 500.0 * p;

        Console.WriteLine("{0:F2}", result);
    }
        
}
