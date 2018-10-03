using System;

    class ModifyBit
    {
        static void Main(string[] args)
        {
        ulong n = ulong.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        bool pTrue = p >= 0 && p < 64;
        int v = int.Parse(Console.ReadLine());
        //bool vTrue = v == 0 || v == 1;

        if (v == 1 && pTrue)
        {
            ulong mask = (ulong)1 << p;
            n = (ulong)n | mask;
            Console.WriteLine(n);
        }
        else
        {
            ulong mask = (ulong)(~(1 << p));
            n = (ulong)(n & mask);
            Console.WriteLine(n);
        }

        }
    }

