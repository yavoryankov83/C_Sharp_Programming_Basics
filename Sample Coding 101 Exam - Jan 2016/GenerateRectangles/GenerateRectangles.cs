using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRectangles
{
    class GenerateRectangles
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());

            var isFound = false;

            for (int left = -n; left <= 0; left++)
            {
                for (int top = -n; top <= 0; top++)
                {
                    for (int right = -n; right <= n; right++)
                    {
                        for (int bottom = -n; bottom <= n; bottom++)
                        {

                            if (-n <= left && left < right && right <= n && -n <= top && top < bottom && bottom <= n)
                            {
                                var area = (Math.Abs(right - left) * (Math.Abs(top - bottom)));
                                if (area >= m)
                                {
                                    Console.WriteLine($"({left}, {top}) ({right}, {bottom}) -> {area}");
                                    isFound = true;
                                }
                            }   
                        }
                    }
                }
            }
            if (isFound == false)
            {
                Console.WriteLine("No");
            }
        }
    }
}
