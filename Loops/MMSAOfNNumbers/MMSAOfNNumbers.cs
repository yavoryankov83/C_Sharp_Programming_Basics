using System;

class MMSAOfNNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int min = int.MaxValue;
        int max = int.MinValue;
        double sum = 0.0;
        double average = 0.0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            min = Math.Min(min, number);

            max = Math.Max(max, number);

            sum += number;

            average = sum / n;

        }
        if (n > 1 && n <= 100)
        {
            Console.WriteLine("Min = {0;f2}", min);
            Console.WriteLine("Max = {0;f2}", max);
            Console.WriteLine("Sum = {0;f2}", sum);
            Console.WriteLine("Average = {0;f2}", average);
        }
    }

}
