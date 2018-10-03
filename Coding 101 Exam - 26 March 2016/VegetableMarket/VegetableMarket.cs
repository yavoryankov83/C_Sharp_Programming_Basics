using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class VegetableMarket
    {
        static void Main(string[] args)
        {
            var vegetablesPrice = double.Parse(Console.ReadLine());
            var fruitsPrice = double.Parse(Console.ReadLine());
            var vegetablesKilos = int.Parse(Console.ReadLine());
            var fruitsKilos = int.Parse(Console.ReadLine());

            var vegetablesProfit = vegetablesPrice * vegetablesKilos;
            var fruitsProfit = fruitsPrice * fruitsKilos;
            var result = (vegetablesProfit + fruitsProfit) / 1.94;

            Console.WriteLine(result);
        }
    }
}
