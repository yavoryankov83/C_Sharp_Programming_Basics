using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastKNumbersSum
{
    class LastKNumbersSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            array[0] = 1;
            for (int i = 1; i < array.Length; i++)
            {
                array[i] = Sum(array, i - k, i - 1);
            }
            Console.Write(string.Join(" ", array));
            Console.WriteLine();
        }

        private static int Sum(int[] arr, int startIndex, int endIndex)
        {
            int sum = 0;
            for (int i = startIndex; i <= endIndex; i++)
            {
                if (i >= 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
    }
}
