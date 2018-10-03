using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyConverter
{
    class CurrencyConverter
    {
        static void Main(string[] args)
        {
            //decimal moneyToString = decimal.Parse(Console.ReadLine());
            //string firstcurrency = Console.ReadLine();
            //string secondcurrency = Console.ReadLine();
            //decimal firstRate = 0.0m;
            //decimal secondRate = 0.0m;

            //if (firstcurrency == "BGN")
            //{
            //    firstRate = 1;
            //}
            //else if (firstcurrency == "USD")
            //{
            //    firstRate = 1.79549m;
            //}
            //else if (firstcurrency == "EUR")
            //{
            //    firstRate = 1.95583m;
            //}
            //else if (firstcurrency == "GBP")
            //{
            //    firstRate = 2.53405m;
            //}
            //if (secondcurrency == "BGN")
            //{
            //    secondRate = 1;
            //}
            //else if (secondcurrency == "USD")
            //{
            //    secondRate = 1.79549m;
            //}
            //else if (secondcurrency == "EUR")
            //{
            //    secondRate = 1.95583m;
            //}
            //else if (secondcurrency == "GBP")
            //{
            //    secondRate = 2.53405m;
            //}

            //decimal result = moneyToString * (firstRate / secondRate);

            //Console.WriteLine("{0} {1}", Math.Round(result, 2), secondcurrency);


            var amount = double.Parse(Console.ReadLine());
            var inCurrency = Console.ReadLine();
            var outCurrency = Console.ReadLine();
            var dataBase = new double[] { 1.79549, 1.95583, 2.53405 };
            var rezult = 0.0;

            if (inCurrency == "BGN")
            {
                if (outCurrency == "USD")
                {
                    rezult = amount * (1 / dataBase[0]);
                    Console.WriteLine($"{rezult:f2} {outCurrency}");
                }
                else if (outCurrency == "EUR")
                {
                    rezult = amount * (1 / dataBase[1]);
                    Console.WriteLine($"{rezult:f2} {outCurrency}");
                }
                else if (outCurrency == "GBP")
                {
                    rezult = amount * (1 / dataBase[2]);
                    Console.WriteLine($"{rezult:f2} {outCurrency}");
                }
            }
            else if (inCurrency == "USD")
            {
                if (outCurrency == "BGN")
                {
                    rezult = amount * dataBase[0];
                    Console.WriteLine($"{rezult:f2} {outCurrency}");
                }
                else if (outCurrency == "EUR")
                {
                    rezult = amount * (dataBase[0] / dataBase[1]);
                    Console.WriteLine($"{rezult:f2} {outCurrency}");
                }
                else if (outCurrency == "GBP")
                {
                    rezult = amount * (dataBase[0] / dataBase[2]);
                    Console.WriteLine($"{rezult:f2} {outCurrency}");
                }
            }
            else if (inCurrency == "EUR")
            {
                if (outCurrency == "USD")
                {
                    rezult = amount * (dataBase[1] / dataBase[0]);
                    Console.WriteLine($"{rezult:f2} {outCurrency}");
                }
                else if (outCurrency == "BGN")
                {
                    rezult = amount * dataBase[1];
                    Console.WriteLine($"{rezult:f2} {outCurrency}");
                }
                else if (outCurrency == "GBP")
                {
                    rezult = amount * (dataBase[1] / dataBase[2]);
                    Console.WriteLine($"{rezult:f2} {outCurrency}");
                }
            }
            if (inCurrency == "GBP")
            {
                if (outCurrency == "USD")
                {
                    rezult = amount * (dataBase[2] / dataBase[0]);
                    Console.WriteLine($"{rezult:f2} {outCurrency}");
                }
                else if (outCurrency == "EUR")
                {
                    rezult = amount * (dataBase[2] / dataBase[1]);
                    Console.WriteLine($"{rezult:f2} {outCurrency}");
                }
                else if (outCurrency == "BGN")
                {
                    rezult = amount * (1 / dataBase[2]);
                    Console.WriteLine($"{rezult:f2} {outCurrency}");
                }
            }
        }
    }
}
