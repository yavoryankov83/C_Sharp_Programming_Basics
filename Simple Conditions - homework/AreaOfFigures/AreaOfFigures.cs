using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();

            var area = 0.0;

            if (figure == "square")
            {
                var side = double.Parse(Console.ReadLine());
                area = side * side;
            }
            else if (figure == "rectangle")
            {
                var side1 = double.Parse(Console.ReadLine());
                var side2 = double.Parse(Console.ReadLine());
                area = side1 * side2;
            }
            else if (figure == "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius;
            }
            else
            {
                var sideA = double.Parse(Console.ReadLine());
                var hight = double.Parse(Console.ReadLine());
                area = sideA * hight / 2;
            }
            Console.WriteLine("{0:f3}", area);
        }
    }
}
