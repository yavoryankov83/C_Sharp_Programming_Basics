using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class HalfSumElement
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var sum = 0;
            var array = new int[count];

            for (int i = 0; i < count; i++)
            {
                var num = int.Parse(Console.ReadLine());
                sum += num;
                array[i] = num;
            }
            foreach (var nums in array)
            {
                if (nums == sum - nums)
                {
                    Console.WriteLine($"Yes Sum = {nums}");
                    break;
                }
                else
                {
                    int maxElement = array.Max();
                    if (Math.Abs((maxElement) - (sum - maxElement)) > 0)
                    {
                        Console.WriteLine($"No, Diff = {Math.Abs((maxElement) - (sum - maxElement))}");
                        break;
                    }
                }
            }
        }
    }
}
