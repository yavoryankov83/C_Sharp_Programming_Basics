using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableShop
{
    class VegetableShop
    {
        static void Main(string[] args)
        {
            var priceVegetables = double.Parse(Console.ReadLine());
            var priceFruits = double.Parse(Console.ReadLine());
            var coantityVegetables = int.Parse(Console.ReadLine());
            var coantityFruits = int.Parse(Console.ReadLine());

            var levaToEuro = 1.94;
            var resultVegetables = priceVegetables * coantityVegetables;
            var resultFruits = priceFruits * coantityFruits;
            var result = (resultFruits + resultVegetables) / levaToEuro;
            Console.WriteLine(result);
        }
    }
}
