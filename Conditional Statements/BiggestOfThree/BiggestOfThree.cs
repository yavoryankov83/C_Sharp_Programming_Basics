using System;

class BiggestOfThree
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        bool isValid = (a >= -200 && a <= 200) && (b >= -200 && b <= 200) && (c >= -200 && c <= 200);

        if (a > b && a > c && isValid)
        {
            Console.WriteLine(a);
        }
        else if (b > a && b > c && isValid)
        {
            Console.WriteLine(b);
        }
        else if (c > a && c > b && isValid)
        {   
            Console.WriteLine(c);
        }
        else if (a == b && a == c && isValid)
        {
            Console.WriteLine(a);
        }
    }
}
