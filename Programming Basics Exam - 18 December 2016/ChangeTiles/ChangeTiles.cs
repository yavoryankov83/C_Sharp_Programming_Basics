using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeTiles
{
    class ChangeTiles
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var wideOfFloor = double.Parse(Console.ReadLine());
            var LengthOfFloor = double.Parse(Console.ReadLine());
            var sideOfTringle = double.Parse(Console.ReadLine());
            var heightOfTriangle = double.Parse(Console.ReadLine());
            var pricePerTile = double.Parse(Console.ReadLine());
            var priceForWorker = double.Parse(Console.ReadLine());

            var areaOfFloor = wideOfFloor * LengthOfFloor;
            var areaOfOneTiles = (sideOfTringle * heightOfTriangle) / 2;
            var neededTiles = Math.Ceiling(areaOfFloor / areaOfOneTiles) + 5;
            var neededMoney = neededTiles * pricePerTile + priceForWorker;

            var areEnought = money >= neededMoney;
            var diff = Math.Abs(money - neededMoney);

            Console.WriteLine(areEnought ? "{0:f2} lv left." : "You'll need {0:f2} lv more.", diff);
        }
    }
}
