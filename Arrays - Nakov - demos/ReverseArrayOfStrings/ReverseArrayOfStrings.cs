using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfStrings
{
    class ReverseArrayOfStrings
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < array.Length / 2; i++)
            {
                string store = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = store;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
