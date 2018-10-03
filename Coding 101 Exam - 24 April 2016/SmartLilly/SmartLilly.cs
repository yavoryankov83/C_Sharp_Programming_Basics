using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLilly
{
    class SmartLilly
    {
        static void Main(string[] args)
        {
            var age = int.Parse(Console.ReadLine());
            var priceOfMachine = double.Parse(Console.ReadLine());
            var priceOfToy = int.Parse(Console.ReadLine());

            var toysCount = 0;
            var moneyCount = 0.0;
            var money = 10;
            var moneyFromToys = 0.0;
            var moneyFotMachine = 0.0;
            var moneyTaken = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 != 0)
                {
                    toysCount++;
                }
                else
                {
                    moneyCount += money;
                    moneyTaken++;
                    money += 10;
                }
            }
            moneyFromToys = toysCount * priceOfToy;
            moneyFotMachine = moneyCount + moneyFromToys - moneyTaken;
            var diff = Math.Abs(moneyFotMachine - priceOfMachine);
            if (moneyFotMachine >= priceOfMachine)
            {
                
                Console.WriteLine("Yes! {0:f2}", diff);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", diff);
            }
        }
    }
}
