using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Division
    {
        static void Main(string[] args)
        {
            var numbetsCount = int.Parse(Console.ReadLine());

            var p1Count = 0.0;
            var p2Count = 0.0;
            var p3Count = 0.0;

            for (int i = 1; i <= numbetsCount; i++)
            {
                var nums = int.Parse(Console.ReadLine());

                if (nums % 2 == 0)
                {
                    p1Count++;
                }
                if (nums % 3 == 0)
                {
                    p2Count++;
                }
                if (nums % 4 == 0)
                {
                    p3Count++;
                }
            }
            var p1 = (p1Count / numbetsCount);
            var p2 = (p2Count / numbetsCount);
            var p3 = (p3Count / numbetsCount);

            Console.WriteLine(p1.ToString("0.00%"));
            Console.WriteLine(p2.ToString("0.00%"));
            Console.WriteLine(p3.ToString("0.00%"));

        }
    }
}
