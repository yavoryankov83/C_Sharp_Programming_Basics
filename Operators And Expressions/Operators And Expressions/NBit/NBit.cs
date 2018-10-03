using System;

class NBit
{
    static void Main(string[] args)
    {
        int p = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        int mask = 1 << n;
        int pAndMask = n & mask;
        int bit = pAndMask >> n;
        long c = (long)Math.Pow(2, 55);

        if (n > 0 && n < 55 && p >= 0 && p <= c)
        {
            Console.WriteLine(bit);
            //Console.WriteLine(Convert.ToString(bit, 2).PadLeft(32, '0'));
        }
    }
}

