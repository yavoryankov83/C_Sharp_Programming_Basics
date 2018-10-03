using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrequentNumber
{
    class FrequentNumber
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            int count = 1;
            int maxCount = 1;
            int number = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);
            for (int j = 1; j < array.Length; j++)
            {
                if (array[j] == array[j - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (count > maxCount)
                {
                    maxCount = count;
                    number = array[j];
                }
            }
            if (array.Length == 1)
            {
                maxCount = 1;
                number = array[0];
            }
            Console.WriteLine("{0} ({1} times)", number, maxCount);
        }
    }
}
