using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairintTiles
{
    class RepairintTiles
    {
        static void Main(string[] args)
        {
            var sideLenght = int.Parse(Console.ReadLine());
            var tilesWidth = double.Parse(Console.ReadLine());
            var tilesLenght = double.Parse(Console.ReadLine());
            var bencheWidth = int.Parse(Console.ReadLine());
            var benchLenght = int.Parse(Console.ReadLine());

            var tilesArea = tilesLenght * tilesWidth;
            var sideArea = sideLenght * sideLenght;
            var benchArea = bencheWidth * benchLenght;
            var tilesTime = 0.2;

            var area = sideArea - benchArea;
            var tilesCount = area / tilesArea;
            var time = tilesCount * tilesTime;

            Console.WriteLine(tilesCount);
            Console.WriteLine(time);
        }
    }
}
