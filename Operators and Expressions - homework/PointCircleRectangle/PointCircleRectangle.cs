using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointCircleRectangle
{
    class PointCircleRectangle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine()); //1. read from the console
            double y = double.Parse(Console.ReadLine()); //2. read from the console

            bool insideCircle = Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2) <= Math.Pow(1.5, 2); //3. use formula from internet to find if given point is in a circle Math.Pow((point(x) - circle(x)), 2) + Math.Pow((point(y) - circle(y)), 2) <= Math.Pow(circle(radius), 2)
            bool insideRectangle = ((-1 <= x && x <= 5) && (-1 <= y && y <= 1)); //4. check if given point is inside the rectangle

            if (insideCircle) // check
            {
                if (insideRectangle) // chek
                {
                    Console.WriteLine("inside circle inside rectangle"); // print
                }
                else
                {
                    Console.WriteLine("inside circle outside rectangle"); // print
                }
            }
            else
            {
                if (insideRectangle) // chek
                {
                    Console.WriteLine("outside circle inside rectangle"); // print
                }
                else
                {
                    Console.WriteLine("outside circle outside rectangle"); // print
                }
            }
        }
    }
}
