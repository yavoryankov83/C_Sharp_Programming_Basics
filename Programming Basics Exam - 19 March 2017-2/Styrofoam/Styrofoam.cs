using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Styrofoam
{
    class Styrofoam
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var houseArea = double.Parse(Console.ReadLine());
            var windowsCount = int.Parse(Console.ReadLine());
            var styrofoamPerPacket = double.Parse(Console.ReadLine());
            var styrofoamPricePerPacket = double.Parse(Console.ReadLine());

            var houseAreaWithoutWindows = houseArea - (windowsCount * 2.4);
            var firi = houseAreaWithoutWindows * 0.1;
            var area = houseAreaWithoutWindows + firi;
            var styrofoamPacageCount = Math.Ceiling(area / styrofoamPerPacket);
            var styrofoamPrice = styrofoamPacageCount * styrofoamPricePerPacket;

            var isEnought = styrofoamPrice <= budget;

            if (isEnought == true)
            {
                Console.WriteLine("Spent: {0:f2}", styrofoamPrice);
                Console.WriteLine("Left: {0:f2}", budget - styrofoamPrice);
            }
            else
            {
                Console.WriteLine("Need more: {0:f2}", styrofoamPrice - budget);
            }
        }
    }
}
