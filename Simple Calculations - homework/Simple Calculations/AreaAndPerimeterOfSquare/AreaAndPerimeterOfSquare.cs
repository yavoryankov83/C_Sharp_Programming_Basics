using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaAndPerimeterOfSquare
{
    class AreaAndPerimeterOfSquare
    {
        static void Main(string[] args)
        {
            var radius = double.Parse(Console.ReadLine());
            var areaOfSquare = Math.PI * radius * radius;
            var perimeterOfSquare = 2 * Math.PI * radius;
            Console.WriteLine("Area = {0}", areaOfSquare);
            Console.WriteLine("Perimeter = {0}", perimeterOfSquare);
        }
    }
}
