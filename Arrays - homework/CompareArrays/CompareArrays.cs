using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] firstArray = new int[N];
            int[] secondArray = new int[N];

            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            for (int j = 0; j < secondArray.Length; j++)
            {
                secondArray[j] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(firstArray.SequenceEqual(secondArray) ? "Equal" : "Not equal");
            {

            }
        }
    }
}
