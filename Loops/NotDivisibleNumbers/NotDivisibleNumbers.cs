﻿using System;

class NotDivisibleNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 || i % 7 == 0 || n < 0 || n > 1500)
            {
                continue; 
            }
            else
            {
                Console.Write(i + " ");
            }
                
        }
        Console.WriteLine();

    }
}
