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
            var side = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            bool insideFistRectangle = x > 0 && x < 3 * side && y > 0 && y < side;
            bool insideSecondRectangle = x > side && x < 2 * side && y > side && y < 4 * side;
            bool onLine = x > side && x < 2 * side && y == side;

            bool outsideFirstRectangle = x < 0 || x > 3 * side || y < 0 || y > side;
            bool outsideSecondRectangle = x < side || x > 2 * side || y < side || y > 4 * side;

            if (insideFistRectangle || insideSecondRectangle || onLine)
            {
                Console.WriteLine("inside");
            }
            else if (outsideFirstRectangle && outsideSecondRectangle)
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}
