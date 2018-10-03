using System;

class SortThreeNumbers
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        bool isValid = (a >= -1000 && a <= 1000) && (b >= -1000 && b <= 1000) && (c >= -1000 && c <= 1000);

        if (a >= b && a > c && isValid)
        {
            if (b >= c)
            {
                Console.WriteLine(a + " " + b + " " + c);
            }
            else
            {
                Console.WriteLine(a + " " + c + " " + b);
            }
            if (b >= c && b > a && isValid)
            {
                if (a >= c)
                {
                    Console.WriteLine(b + " " + a + " " + c);
                }
                else
                {
                    Console.WriteLine(b + " " + c + " " + a);
                }
                if (c >= a && c > b && isValid)
                {
                    if (a >= b)
                    {
                        Console.WriteLine(c + " " + a + " " + b);
                    }
                    else
                    {
                        Console.WriteLine(c + " " + b + " " + a);
                    }
                    if (a == b && a == c && isValid)
                    {
                        Console.WriteLine(a + " " + b + " " + c);

                    }
                }

            }
        }
    }
}
