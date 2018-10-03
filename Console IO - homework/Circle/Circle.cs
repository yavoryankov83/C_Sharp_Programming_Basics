using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Circle
    {
        static void Main(string[] args)
        {
            double radiusOfCircle = double.Parse(Console.ReadLine());
            double areaOfCircle = Math.PI * Math.Pow(radiusOfCircle, 2);
            double perimeterOfCircle = 2 * Math.PI * radiusOfCircle;
            Console.WriteLine("{0:F2} {1:F2}", perimeterOfCircle, areaOfCircle);
        }
    }
}
