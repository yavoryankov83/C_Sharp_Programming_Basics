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

            var noRectangle = true;

            for (int left = -n; left <= n; left++)
            {
                for (int top = -n; top <= n; top++)
                {
                    for (int right = left + 1; right <= n; right++)
                    {
                        for (int bottom = top + 1; bottom <= n; bottom++)
                        {
                            int currentArea = Math.Abs((right - left)) * Math.Abs((top - bottom));

                            if (currentArea >= m)
                            {
                                Console.WriteLine($"({left}, {top}) ({right}, {bottom}) -> {currentArea};");
                                noRectangle = false;
                            }

                            if (left >= right || top >= bottom)
                            {
                                return;
                            }
                        }
                    }
                }
            }
            if (noRectangle == true)
            {
                Console.WriteLine("No");
            }
        }
    }
}
