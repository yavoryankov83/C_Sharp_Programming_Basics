using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackToThePast
{
    class BackToThePast
    {
        static void Main(string[] args)
        {
            var fortune = double.Parse(Console.ReadLine());
            var endDate = int.Parse(Console.ReadLine());

            var age = 18;
            var startDate = 1800;
            var moneyForSpendEven = 0.0;
            var moneyForSpendOdd = 0.0;
            var moneyForSpend = 0.0;

            for (int i = startDate; i <= endDate; i++)
            {
                if (i % 2 == 0)
                {
                    moneyForSpendEven += 12000;
                }
                else
                {
                    moneyForSpendOdd = moneyForSpendOdd + 12000 + 50 * age;
                }
                age++;
                moneyForSpend = moneyForSpendEven + moneyForSpendOdd;
            }
            var diff = Math.Abs(fortune - moneyForSpend);

            if (fortune >= moneyForSpend)
            {
                Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", diff);
            }
            else
            {
                Console.WriteLine("He will need {0:f2} dollars to survive.", diff);
            }
        }
    }
}
