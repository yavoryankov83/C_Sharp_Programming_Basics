using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            if (1 <= N && N <= 1024)
            {
                Array.Sort(array);
                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
