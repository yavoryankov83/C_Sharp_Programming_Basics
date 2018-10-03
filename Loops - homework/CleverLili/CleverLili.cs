using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleverLili
{
    class CleverLili
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var mashinePrice = double.Parse(Console.ReadLine());
            var toyPrice = int.Parse(Console.ReadLine());

            var toysCount = 0;
            var moneyCount = 1;
            var moneyTaken = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    toysCount++;
                }
                else
                {
                    moneyCount += i * 5;
                    moneyTaken += 1;
                }
            }
            moneyCount = moneyCount - 1;
            int moneyOfToys = toysCount * toyPrice;
            double moneySaved = moneyCount + moneyOfToys - moneyTaken;

            if (moneySaved >= mashinePrice)
            {
                Console.WriteLine("Yes! {0:f2}", moneySaved - mashinePrice);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", mashinePrice - moneySaved);
            }
        }
    }
}
