using System;

class BitsToBits
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int zeroMaxCount = 0;
        int zeroCurrentCount = 0;

        int oneMaxCount = 0;
        int oneCurrentCount = 0;

        int lastBit = 5;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            for (int j = 29; j >= 0; j--)
            {
                int bit = (1 << j & number) >> j;

                if (bit == 1)
                {
                    if (lastBit == 1)
                    {
                        oneCurrentCount++;
                        oneMaxCount = Math.Max(oneMaxCount, oneCurrentCount);
                    }
                    else
                    {
                        zeroMaxCount = Math.Max(zeroMaxCount, zeroCurrentCount);
                        zeroCurrentCount = 0;
                        oneCurrentCount = 1;
                    }
                }
                else
                {
                    if (lastBit == 0)
                    {
                        zeroCurrentCount++;
                        zeroMaxCount = Math.Max(zeroMaxCount, zeroCurrentCount);
                    }
                    else
                    {
                        oneMaxCount = Math.Max(oneMaxCount, oneCurrentCount);
                        oneCurrentCount = 0;
                        zeroCurrentCount = 1;
                    }
                }
                lastBit = bit;
            }
            
        }
        Console.WriteLine(zeroMaxCount);
        Console.WriteLine(oneMaxCount);
    }
}
