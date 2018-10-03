using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Pets
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var food = int.Parse(Console.ReadLine());
            var dogDailyFood = double.Parse(Console.ReadLine());
            var catDailyFood = double.Parse(Console.ReadLine());
            var tortouseDailyFood = double.Parse(Console.ReadLine());

            var tortouseDailyFoodKilos = tortouseDailyFood / 1000;
            var eatenFood = days * dogDailyFood + days * catDailyFood + days * tortouseDailyFoodKilos;
            var diff = Math.Abs(food - eatenFood);
            var isEnought = food >= eatenFood;

            Console.WriteLine(isEnought ? $"{Math.Floor(diff)} kilos of food left." : $"{Math.Ceiling(diff)} more kilos of food are needed.");
        }
    }
}
