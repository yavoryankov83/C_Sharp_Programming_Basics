using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumMinMaxFirstLastAverageOfArray
{
    class SumMinMaxFirstLastAverageOfArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var array = new int[n];
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine(sum);
            Console.WriteLine(array.Min());
            Console.WriteLine(array.Max());
            Console.WriteLine(array.First());
            Console.WriteLine(array.Last());
            Console.WriteLine(array.Average());
        }
    }
}
