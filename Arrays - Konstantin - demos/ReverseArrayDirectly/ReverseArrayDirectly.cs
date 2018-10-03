using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayDirectly
{
    class ReverseArrayDirectly
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2, 14, 45, -3 };

            for (int i = 0; i < array.Length / 2; i++)
            {
                int store = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = store;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
