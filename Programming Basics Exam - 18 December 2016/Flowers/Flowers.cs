using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Flowers
    {
        static void Main(string[] args)
        {
            var hrizantemaCount = int.Parse(Console.ReadLine());
            var rosesCount = int.Parse(Console.ReadLine());
            var laletaCount = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var day = Console.ReadLine();

            var hrizantemaPrice = 0.0;
            var rosesPrice = 0.0;
            var laletaPrice = 0.0;

            var price = 0.0;

            if (season == "Spring" || season == "Summer")
            {
                hrizantemaPrice = 2.0 * hrizantemaCount;
                rosesPrice = 4.10 * rosesCount;
                laletaPrice = 2.50 * laletaCount;
            }
            else
            {
                hrizantemaPrice = 3.75 * hrizantemaCount;
                rosesPrice = 4.50 * rosesCount;
                laletaPrice = 4.15 * laletaCount;
            }

            price = hrizantemaPrice + rosesPrice + laletaPrice;

            if (day == "Y")
            {
                price = price + price * 0.15;
            }
            if (laletaCount > 7 && season == "Spring")
            {
                price = price - price * 0.05;
            }
            if (rosesCount >= 10 && season == "Winter")
            {
                price = price - price * 0.1;
            }
            if (hrizantemaCount + rosesCount + laletaCount > 20)
            {
                price = price - price * 0.2;
            }

            price += 2;

            Console.WriteLine("{0:f2}", price);
        }
    }
}
