using System;

class PrintTheAsciiTable
{
    static void Main(string[] args)
    {
        int counter = 33;
        char symbol = Convert.ToChar(counter);
        for (counter = 33; counter < 127; counter++)
        {
            symbol = Convert.ToChar(counter);
            Console.WriteLine(symbol);
        }
    }
}

