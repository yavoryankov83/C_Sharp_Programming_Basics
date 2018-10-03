using System;

class CalculateAgain
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        int factorielN = 1;
        int factorielK = 1;
        int result = 0;

        if (k > 1 && k < n && n < 100)
        {
            for (int i = 1; i <= n; i++)
            {
                factorielN *= i;
            }
            for (int j = 1; j <= k; j++)
            {
                factorielK *= j;
            }

            result = factorielN / factorielK;

            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("invalid input");
        }
    }
}
