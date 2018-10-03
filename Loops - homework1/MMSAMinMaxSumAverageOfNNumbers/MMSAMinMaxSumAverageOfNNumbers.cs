using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSAMinMaxSumAverageOfNNumbers
{
    class MMSAMinMaxSumAverageOfNNumbers
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double min = double.MaxValue;
            double max = double.MinValue;
            double sum = 0;
            double average = 1;

            for (int i = 1; i <= N; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
                sum += number;
                average = sum / N;
            }
            Console.WriteLine("min={0:F2}", min);
            Console.WriteLine("max={0:F2}", max);
            Console.WriteLine("sum={0:F2}", sum);
            Console.WriteLine("avg={0:F2}", average);
        }
    }
}
