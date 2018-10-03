using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArray
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 14, 45, -3 };

            int[] reversedArray = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                reversedArray[array.Length - i - 1] = array[i];
            }
            Console.WriteLine(string.Join(" ", reversedArray));
        }
    }
}
