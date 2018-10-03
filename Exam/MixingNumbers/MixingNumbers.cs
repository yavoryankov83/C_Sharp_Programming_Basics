using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixingNumbers
{
    class MixingNumbers
    {
        static void Main(string[] args)
        {
            //first solution
            //int N = int.Parse(Console.ReadLine());

            //int[] numbers = new int[N];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //int[] mixedNumbers = new int[N - 1];
            //int[] sustractNumbers = new int[N - 1];

            //for (int i = 1; i < N; i++)
            //{
            //    mixedNumbers[i - 1] = numbers[i - 1] % 10 * (numbers[i] / 10);
            //    sustractNumbers[i - 1] = numbers[i - 1] - numbers[i];
            //    if (sustractNumbers[i - 1] < 0)
            //    {
            //        sustractNumbers[i - 1] *= -1;
            //    }
            //}
            //Console.WriteLine(string.Join(" ", mixedNumbers));
            //Console.WriteLine(string.Join(" ", sustractNumbers));

            //second solution
            int N = int.Parse(Console.ReadLine());

            int[] numbers = new int[N];
            int[] mixedNumbers = new int[N - 1];
            int[] substractNumbers = new int[N - 1];

            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < N - 1; i++)
            {
                int b = numbers[i] % 10;
                int c = numbers[i + 1] / 10;
                mixedNumbers[i] = b * c;
            }

            for (int i = 0; i < N - 1; i++)
            {
                substractNumbers[i] = numbers[i] - numbers[i + 1];
                if (substractNumbers[i] < 0)
                {
                    substractNumbers[i] = substractNumbers[i] * -1;
                }
            }
            Console.WriteLine(String.Join(" ", mixedNumbers));
            Console.WriteLine(String.Join(" ", substractNumbers));
        }
    }
}
