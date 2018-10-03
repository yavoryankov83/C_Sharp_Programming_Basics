using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMaxElement
{
    class ArrayMaxElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var array = new int[n];
            int max = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
