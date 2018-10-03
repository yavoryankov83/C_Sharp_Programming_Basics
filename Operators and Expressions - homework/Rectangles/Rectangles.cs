using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine()); //1. read from the console
            double height = double.Parse(Console.ReadLine()); //2. read from the console
            double area = width * height; //3. find area formula
            double perimeter = 2 * width + 2 * height; // 4. find perimeter formula

            Console.WriteLine("{0:F2} {1:F2}", area, perimeter); //print with precision /F2/
        }

    }
}
