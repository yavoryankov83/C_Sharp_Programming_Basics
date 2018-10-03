using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingElements
{
    class IncreasingElements
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var count = 0;
            var maxCount = 0;
            var max = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num > max)
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
                }
                max = num;
            }
            Console.WriteLine(maxCount);
        }
    }
}
