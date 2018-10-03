using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks
{
    class Bricks
    {
        static void Main(string[] args)
        {
            var bricksCount = int.Parse(Console.ReadLine());
            var workersCount = int.Parse(Console.ReadLine());
            var carCapacity = int.Parse(Console.ReadLine());

            var carsCount = carCapacity * workersCount;
            var carsTimes = bricksCount / (double)carsCount;
            Console.WriteLine(Math.Ceiling(carsTimes));
        }
    }
}
