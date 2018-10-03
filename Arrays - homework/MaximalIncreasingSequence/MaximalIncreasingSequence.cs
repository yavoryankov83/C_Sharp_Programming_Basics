using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalIncreasingSequence
{
    class MaximalIncreasingSequence
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            int count = 1;
            int maxCount = 1;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            if (1 <= N && N <= 1024)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j + 1] - array[j] >= 1)
                    {
                        count++;
                        if (count > maxCount)
                        {
                            maxCount = count;
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }
                Console.WriteLine(maxCount);
            }
        }
    }
}
