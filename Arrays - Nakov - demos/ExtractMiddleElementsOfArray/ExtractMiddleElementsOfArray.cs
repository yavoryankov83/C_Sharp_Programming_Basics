using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMiddleElementsOfArray
{
    class ExtractMiddleElementsOfArray
    {
        static void Main(string[] args)
        {
            // first way
            //var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //for (int i = 0; i < array.Length / 2 + 1; i++)
            //{
            //    if (array.Length == 1)
            //    {
            //        Console.WriteLine(string.Join(" ", array));
            //    }
            //    else if (array.Length % 2 == 0)
            //    {
            //        Console.WriteLine(array[array.Length / 2 - 1] + " " + array[array.Length / 2]);
            //        break;

            //    }
            //    else
            //    {
            //        Console.WriteLine(array[array.Length / 2 - 1] + " " + array[array.Length / 2] + " " + array[array.Length / 2 + 1]);
            //        break;
            //    }
            //}

            //second way
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var result = Middle(array);
            Console.WriteLine(string.Join(" ", result));
        }

        private static int[] Middle(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums;
            }
            if (nums.Length % 2 == 0)
            {
                return new int[] { nums[nums.Length / 2 - 1], nums[nums.Length / 2] };
            }
            else
            {
                return new int[] { nums[nums.Length / 2 - 1], nums[nums.Length / 2], nums[nums.Length / 2 + 1] };
            }
        }
    }
}
