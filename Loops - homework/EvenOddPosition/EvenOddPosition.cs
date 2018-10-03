using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddPosition
{
    class EvenOddPosition
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            var evenSum = 0.0;
            var oddSum = 0.0;
            var evenMax = double.MinValue;
            var oddMax = double.MinValue;
            var evenMin = double.MaxValue;
            var oddMin = double.MaxValue;

            for (int i = 1; i <= count; i++)
            {
                var num = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += num;

                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                }
                else
                {
                    oddSum += num;

                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                }
            }
            Console.WriteLine($"OddSum={oddSum}" + ",");
            Console.WriteLine(count == 0 ? "OddMin=No," : $"OddMin={oddMin}" + ",");
            Console.WriteLine(count == 0 ? "OddMax=No," : $"OddMax={oddMax}" + ",");
            Console.WriteLine($"EvenSum={evenSum}" + ",");
            Console.WriteLine(count == 0 || count == 1 ? "EvenMin=No," : $"EvenMin={evenMin}" + ",");
            Console.WriteLine(count == 0 || count == 1 ? "EvenMax=No" : $"EvenMax={evenMax}");
        }
    }
}
