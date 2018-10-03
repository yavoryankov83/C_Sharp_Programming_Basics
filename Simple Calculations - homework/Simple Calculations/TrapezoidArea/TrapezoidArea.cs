using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidArea
{
    class TrapezoidArea
    {
        static void Main(string[] args)
        {
            var sideA = double.Parse(Console.ReadLine());
            var sideB = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            var trapezoisArea = (sideA + sideB) * height / 2;
            Console.WriteLine(trapezoisArea);
        }
    }
}
