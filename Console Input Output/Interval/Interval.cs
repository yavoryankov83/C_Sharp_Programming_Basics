using System;

class Interval
{
    static void Main(string[] args)
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        int counter = 0;

        bool isValidNM = start >= 0 && end <= 2000;

        for (int i = start; i <= end; i++)
        {
            if (i % 5 == 0 && isValidNM)
            {
                Console.Write(i + " ");
                counter++;
            }
        }
 
        Console.WriteLine();
        Console.WriteLine("There is {0} numbers dividable by 5!", counter);
    }
}
