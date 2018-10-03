using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeNumbers
{
    class ExchangeNumbers
    {
        static void Main(string[] args)
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());

            double store1 = A;
            double store2 = B;

            if (A > B)
            {
                store1 = B;
                store2 = A;
            }
            Console.WriteLine("{0} {1}", store1, store2);
        }
    }
}
