using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCondence
{
    class ArrayCondence
    {
        static void Main(string[] args)
        {
            //first way
            //var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            //while (nums.Length > 1)
            //{
            //    var result = new int[nums.Length - 1];

            //    for (int i = 0; i < result.Length; i++)
            //    {
            //        result[i] = nums[i] + nums[i + 1];
            //    }
            //    nums = result;
            //}
            //Console.WriteLine(string.Join(" ", nums));

            //second way
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1; j++)
                {
                    nums[j] = nums[j] + nums[j + 1];
                }
            }
            Console.WriteLine(nums[0]);
        }
    }
}
