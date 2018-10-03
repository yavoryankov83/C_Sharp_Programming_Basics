using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProfit
{
    class DailyProfit
    {
        static void Main(string[] args)
        {
            var workDays = int.Parse(Console.ReadLine());
            var profitPerDay = double.Parse(Console.ReadLine());
            var dollarChange = double.Parse(Console.ReadLine());

            var taxes = 25 / 100.0;
            var profitPerMonth = workDays * profitPerDay;
            var bonus = 2.5 * profitPerMonth;
            var profitPerYearWithTaxes = profitPerMonth * 12 + bonus;
            var profitPerYearWithoutTaxes = profitPerYearWithTaxes - (taxes * profitPerYearWithTaxes);
            var averageProfitPerDay = profitPerYearWithoutTaxes / 365;
            var profitInLeva = averageProfitPerDay * dollarChange;

            Console.WriteLine("{0:f2}", profitInLeva);

        }
    }
}
