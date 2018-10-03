using System;

class BiggestOfFive
{
    static void Main(string[] args)
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());

        bool isValid = (a >= -200 && a <= 200) && (b >= -200 && b <= 200) && (c >= -200 && c <= 200) &&
            (d >= -200 && d <= 200) && (e >= -200 && e <= 200);

        if (a > b && a > c && a > d && a > e && isValid)
        {
            Console.WriteLine(a);
        }
        else if (b > a && b > c && b > d && b > e && isValid)
        {
            Console.WriteLine(b);
        }
        else if (c > a && c > b && c > d && c > e && isValid)
        {
            Console.WriteLine(c);
        }
        else if (d > a && d > b && d > c && d > e && isValid)
        {
            Console.WriteLine(d);
        }
        else if (e > a && e > b && e > c && e > d && isValid)
        {

        }
        else if (a == b && a == c && a == d && a == e && isValid)
        {
            Console.WriteLine(a);
        }
    }
}
