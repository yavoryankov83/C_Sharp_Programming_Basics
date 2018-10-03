using System;

    class Bit
    {
        static void Main(string[] args)
        {
        int num = int.Parse(Console.ReadLine());
        int p = 3;
        int mask = 1 << p;
        int numAndMask = num & mask;
        int bit = numAndMask >> p;
        Console.WriteLine(bit);
        }
    }

