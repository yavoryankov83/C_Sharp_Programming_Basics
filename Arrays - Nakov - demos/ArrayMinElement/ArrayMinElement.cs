using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMinElement
{
    class ArrayMinElement
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var array = new int[n];
            int min = int.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine(min);
        }
    }
}
