using System;

class OddAndEvenProduct
{
    static void Main(string[] args)
    {
        int even = 1;
        int odd = 1;

        string readNumbers = Console.ReadLine();
        string[] numbers = readNumbers.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < numbers.Length; i++)
        {
            int number = int.Parse(numbers[i]);

            if (i % 2 == 0)
            {
                even *= number;
            }
            else
            {
                odd *= number;
            }
        }

        if (even == odd)
        {
            Console.WriteLine("yes + {0}", even);
        }
        else
        {
            Console.WriteLine("no" + " " + "{0}" + " " + "{1}", even, odd);
        }
    }
}