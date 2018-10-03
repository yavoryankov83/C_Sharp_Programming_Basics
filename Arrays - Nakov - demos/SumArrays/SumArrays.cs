using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class SumArrays
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var length = Math.Max(arr1.Length, arr2.Length);

            var array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
