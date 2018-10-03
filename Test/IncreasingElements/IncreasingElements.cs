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

            var max = int.MinValue;
            var lenght = 0;
            var maxLenght = 0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num > max)
                {
                    lenght++;
                }
                else
                {
                    lenght = 1;
                }
                if (lenght > maxLenght)
                {
                    maxLenght = lenght;
                }
                max = num;
            }
            Console.WriteLine(maxLenght);
        }
    }
}
