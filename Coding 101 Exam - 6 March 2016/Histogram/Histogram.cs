using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            var numsCount = int.Parse(Console.ReadLine());
            var p1Count = 0.0;
            var p2Count = 0.0;
            var p3Count = 0.0;
            var p4Count = 0.0;
            var p5Count = 0.0;

            for (int i = 0; i < numsCount; i++)
            {
                var num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    p1Count++;
                }
                else if (num >= 200 && num < 400)
                {
                    p2Count++;
                }
                else if (num >= 400 && num < 600)
                {
                    p3Count++;
                }
                else if (num >= 600 && num < 800)
                {
                    p4Count++;
                }
                else if (num >= 800)
                {
                    p5Count++;
                }
            }
            Console.WriteLine("{0}", (p1Count / numsCount).ToString("0.00%"));
            Console.WriteLine("{0}", (p2Count / numsCount).ToString("0.00%"));
            Console.WriteLine("{0}", (p3Count / numsCount).ToString("0.00%"));
            Console.WriteLine("{0}", (p4Count / numsCount).ToString("0.00%"));
            Console.WriteLine("{0}", (p5Count / numsCount).ToString("0.00%"));
        }
    }
}
