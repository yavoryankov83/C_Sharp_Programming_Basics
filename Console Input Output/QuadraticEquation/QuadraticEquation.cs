using System;

class QuadraticEquation
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double discriminant = (b * b) - (4 * a * c);
        bool isValid = (a >= -1000 && a <= 1000) && (b >= -1000 && b <= 1000) && (c >= -1000 && c <= 1000);

        if (isValid && discriminant > 0)
        {
            double x2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
            double x1 = ((-b) - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("{0:f2}", Math.Min(x1, x2));
            Console.WriteLine("{0:f2}", Math.Max(x1, x2));
        }
        else if (isValid && discriminant == 0)
        {
            double x1Andx2 = ((-b) + Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("{0:f2}", x1Andx2);
        }
        else if (isValid && discriminant < 0)
        {
            Console.WriteLine("no real roots");
        }
    }
}

