using System;

class PrintSequence
{
    static void Main(string[] args)
    {
        for (int i = 2, j = -3; i < 1001; i += 2, j -= 2)
        {
            Console.WriteLine(i);
            Console.WriteLine(j);
        }
    }
}
