using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Money
    {
        static void Main(string[] args)
        {
            var bitcoinCount = int.Parse(Console.ReadLine());
            var ioanaCount = double.Parse(Console.ReadLine());
            var comision = double.Parse(Console.ReadLine());

            var bitcoinValueInLeva = bitcoinCount * 1168;
            var ioanaValueInDollar = ioanaCount * 0.15;
            var ioanaValueInLeva = ioanaValueInDollar * 1.76;
            var moneyInLeva = bitcoinValueInLeva + ioanaValueInLeva;
            var moneyInEuro = moneyInLeva / 1.95;
            var comisionValue = moneyInEuro * comision / 100;
            var money = moneyInEuro - comisionValue;

            Console.WriteLine(money);
        }
    }
}
