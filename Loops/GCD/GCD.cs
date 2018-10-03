using System;

class GCD
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        while (b != 0)
        {
            int temp;
            temp = b;
            b = a % b;
            a = temp;
        }
        Console.WriteLine("GDC: {0}", a);

    }
}
