using System;

class MatrixOfNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        if (n >= 1 && n <= 20)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(i + j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
