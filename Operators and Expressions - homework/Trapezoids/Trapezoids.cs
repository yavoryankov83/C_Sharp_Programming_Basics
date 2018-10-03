using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine()); //1. read from the console
            double b = double.Parse(Console.ReadLine()); //2. read from the console
            double c = double.Parse(Console.ReadLine()); //3. read from the console

            double areaOfTrapezoid = ((a + b) / 2) * c; //4. find the formula to calculate the area

            Console.WriteLine("{0:F7}", areaOfTrapezoid); // print
        }
    }
}
