using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop
{
    class FlowerShop
    {
        static void Main(string[] args)
        {
            var magnoliiCount = int.Parse(Console.ReadLine());
            var zumbuliCount = int.Parse(Console.ReadLine());
            var rosesCount = int.Parse(Console.ReadLine());
            var cactusCount = int.Parse(Console.ReadLine());
            var giftPrice = double.Parse(Console.ReadLine());

            var flowersPrice = 3.25 * magnoliiCount + 4 * zumbuliCount + 3.5 * rosesCount + 8 * cactusCount;
            var taxes = flowersPrice * 0.05;
            var profit = flowersPrice - taxes;
            var isEnought = profit >= giftPrice;
            var sum = Math.Abs(profit - giftPrice);

            Console.WriteLine(isEnought ? $"She is left with {Math.Floor(sum)} leva." : $"She will have to borrow {Math.Ceiling(sum)} leva.");
        }
    }
}
