using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximalKSum
{
    class MaximalKSum
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            if (1 <= N && N <= 1024 && 1 <= K && K <= N)
            {
                Array.Sort(numbers);
                for (int j = numbers.Length - 1; j >= numbers.Length - K; j--)
                {
                    sum += numbers[j];
                }
                Console.Write(sum);
            }
        }
    }
}
