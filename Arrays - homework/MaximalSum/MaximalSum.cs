using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            int sum = 0;
            int maxSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            if (1 <= N && N <= 1024)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    sum += array[j];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                    else if (sum < 0)
                    {
                        sum = 0;
                    }
                }
                Console.WriteLine(maxSum);
            }
        }
    }
}
