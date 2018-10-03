using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfIntegers
{
    class ReverseArrayOfIntegers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length / 2; i++)
            {
                var store = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = store;
            }
            Console.Write(string.Join(" ", array));
            Console.WriteLine();
        }
    }
}
