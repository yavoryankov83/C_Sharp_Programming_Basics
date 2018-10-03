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
            var bitcoin = int.Parse(Console.ReadLine());
            var uana = double.Parse(Console.ReadLine());
            var comision = double.Parse(Console.ReadLine());

            var bitcoinToLeva = 1168;
            var uanaToDollar = 0.15;
            var dollarToLeva = 1.76;
            var euroToLeva = 1.95;

            var bitcoinInToLeva = bitcoin * bitcoinToLeva;

            var uanaInDollar = uana * uanaToDollar;
            var uanaInLeva = uanaInDollar * dollarToLeva;

            var bitcoinAndUanaInEuro = (bitcoinInToLeva + uanaInLeva) / euroToLeva;
            var totalComision = comision * bitcoinAndUanaInEuro / 100;

            Console.WriteLine(bitcoinAndUanaInEuro - totalComision);
        }
    }
}
