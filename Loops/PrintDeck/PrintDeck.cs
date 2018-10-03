using System;

class PrintDeck
{
    static void Main(string[] args)
    {
        char card = char.Parse(Console.ReadLine());

        for (int i = 2;  i  <= 14;  i ++)
        {
            if (i <= 10)
            {
                Console.Write(i.ToString());
            }

        }
    }
}
