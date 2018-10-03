using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindSumInArray
{
    class FindSumInArray
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int S = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            int sum = 0;

            for (int j = 0; j < array.Length; j++)
            {
                array[j] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int h = i; h < array.Length; h++)
                {
                    sum += array[h];
                    if (sum == S)
                    {
                        for (int k = i; k <= h; k++)
                        {
                            Console.Write("{0}, ", array[k]);
                        }
                        Console.WriteLine();
                    }
                }
                sum = 0;
            }
        }
    }
}
