using System;

class FormattingNumbers
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());
        bool isA = a >= 0 && a <= 500;

        while (isA)
        {
            Console.Write("{0,-10:X}", a);
            Console.Write(Convert.ToString(a, 2).PadLeft(10, '0'));
            Console.Write("{0,10:f2}", b);
            Console.WriteLine("{0,10:f3}", c);
            break;
        }
        Console.WriteLine("Invalid input! Try again!");
        int d = int.Parse(Console.ReadLine());
    }

}

