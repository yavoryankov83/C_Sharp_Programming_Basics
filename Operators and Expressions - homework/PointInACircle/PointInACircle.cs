using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine()); //1. read from the console
            double y = double.Parse(Console.ReadLine()); //2. read from the console
            double c = Math.Sqrt(x * x + y * y); //3. find formula to calculate the distance fron center to the point

            if (-2 < x && x < 2 && -2 < y && y < 2) //4. sheck if point is inside the circle
            {
                Console.WriteLine("yes" + " " + "{0:F2}", c); // print
            }
            else
            {
                Console.WriteLine("no" + " " + "{0:F2}", c); // print
            }

        }
    }
}
