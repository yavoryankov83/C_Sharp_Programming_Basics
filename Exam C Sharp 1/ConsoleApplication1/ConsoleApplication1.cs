using System;
using System.Numerics;

class ConsoleApplication1
{
    static void Main(string[] args)
    {
        int index = 0;
        BigInteger globalProduct = 1;

        while (true)
        {
            string line = Console.ReadLine();

            if (line == "END")
            {
                break;
            }

            if (index == 10)
            {
                Console.WriteLine(globalProduct);
                globalProduct = 1;
            }

            BigInteger num = BigInteger.Parse(line);
            if (num % 2 == 1)
            {
                int product = 1;

                while (num > 0)
                {
                    BigInteger digit = num % 10;
                    if (digit != 0)
                    {
                        product *= digit;
                    }
                    num /= 10;
                }
                globalProduct *= product;
            }
            index = index + 1;
        }
        Console.WriteLine(globalProduct);
    }

}
