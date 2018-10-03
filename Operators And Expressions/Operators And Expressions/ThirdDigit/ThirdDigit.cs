using System;

class ThirdDigit
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int a = (n / 100) % 10;

        if (a == 7)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false" + " " + a);
        }
    }
}

