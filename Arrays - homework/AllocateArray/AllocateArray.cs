﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllocateArray
{
    class AllocateArray
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];

            for (int i = 0; i < N; i++)
            {
                array[i] = i * 5;
            }
            for (int j = 0; j < N; j++)
            {
                Console.WriteLine(array[j]);
            }

        }
    }
}
