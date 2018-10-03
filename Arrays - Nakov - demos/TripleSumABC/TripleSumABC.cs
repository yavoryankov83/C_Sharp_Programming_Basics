using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSumABC
{
    class TripleSumABC
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    int a = array[i];
                    int b = array[j];
                    int sum = a + b;
                    if (array.Contains(sum))
                    {
                        count++;
                        Console.WriteLine($"{a} + {b} = {sum}");
                    }
                }
            }
            if (count == 0)
            {
                Console.WriteLine("no");
            }
        }
    }
}   
