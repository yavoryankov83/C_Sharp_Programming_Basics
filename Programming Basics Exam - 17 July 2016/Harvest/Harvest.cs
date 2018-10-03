using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harvest
{
    class Harvest
    {
        static void Main(string[] args)
        {
            var area = int.Parse(Console.ReadLine());
            var grapePerMeter = double.Parse(Console.ReadLine());
            var neededWine = int.Parse(Console.ReadLine());
            var workersCount = int.Parse(Console.ReadLine());

            var grapeArea = area * 0.4;
            var grapeKilos = grapeArea * grapePerMeter;
            var harvestWine = grapeKilos / 2.5;

            var isNotEnought = harvestWine < neededWine;

            if (isNotEnought == true)
            {
                var notEnoghtWine = neededWine - harvestWine;
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(notEnoghtWine)} liters wine needed.");
            }
            else
            {
                var enoughtWine = harvestWine - neededWine;
                var workerWine = enoughtWine / workersCount;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(harvestWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(enoughtWine)} liters left -> {Math.Ceiling(workerWine)} liters per person.");
            }
        }
    }
}
