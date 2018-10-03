using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInFigure
{
    class PointInFigure
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var isInside1 = (x >= 2 && x < 4) && (y <= 1 && y >= -3);
            var isInside2 = (x > 10 && x <= 12) && (y <= 1 && y >= -3);
            var isInside3 = (x >= 4 && x <= 10) && (y <= 3 && y >= -5);

            if (isInside1 == true || isInside2 == true || isInside3 == true)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
        }
    }
}
