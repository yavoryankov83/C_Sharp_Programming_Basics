using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Profit
    {
        static void Main(string[] args)
        {
            var workDays = int.Parse(Console.ReadLine());
            var earnedMoney = double.Parse(Console.ReadLine());
            var dollarToLev = double.Parse(Console.ReadLine());

            
            var moneyPerMonth = workDays * earnedMoney;
            var moneyPerDay = moneyPerMonth / 365;
            var bonus = 2.5 * moneyPerMonth;
            var moneyPerYear = moneyPerMonth * 12 + bonus;
            var taxes = moneyPerYear * 0.25;
            var realProfitPerYear = moneyPerYear - taxes;
            var profitPerDayInLeva = (realProfitPerYear / 365) * dollarToLev;

            Console.WriteLine("{0:f2}", profitPerDayInLeva);
        }
    }
}
