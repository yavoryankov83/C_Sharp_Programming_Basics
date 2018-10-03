using System;

class NumbersFromOneToN
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int number = 1;

        while (number <= n && n > 0)
        {
            Console.Write(number + " ");
            number++;
        }
    }
}
