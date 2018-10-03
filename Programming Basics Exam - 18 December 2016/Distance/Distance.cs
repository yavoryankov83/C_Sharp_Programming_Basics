using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Distance
    {
        static void Main(string[] args)
        {
            var startSpeed = int.Parse(Console.ReadLine());
            var firstTimeInMinutes = int.Parse(Console.ReadLine());
            var secondTimeInMinutes = int.Parse(Console.ReadLine());
            var thirdTimeInMinutes = int.Parse(Console.ReadLine());

            var firstDistance = startSpeed * (firstTimeInMinutes / 60.0);
            var secondDistance = (startSpeed + startSpeed * 0.1) * (secondTimeInMinutes / 60.0);
            var thirdDistance = ((startSpeed + startSpeed * 0.1) - ((startSpeed + startSpeed * 0.1) * 0.05)) * (thirdTimeInMinutes / 60.0);

            var distance = firstDistance + secondDistance + thirdDistance;

            Console.WriteLine("{0:f2}", distance);
        }
    }
}
