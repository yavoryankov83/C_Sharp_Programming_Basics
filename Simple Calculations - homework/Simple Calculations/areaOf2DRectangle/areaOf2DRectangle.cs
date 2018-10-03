using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace areaOf2DRectangle
{
    class areaOf2DRectangle
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var sideA = Math.Abs(x1 - x2);
            var sideB = Math.Abs(y1 - y2);
            var areaOf2DRectangle = sideA * sideB;
            var perimeterOf2DRectangle = 2 * (sideA + sideB);
            Console.WriteLine(areaOf2DRectangle);
            Console.WriteLine(perimeterOf2DRectangle);
        }
    }
}
