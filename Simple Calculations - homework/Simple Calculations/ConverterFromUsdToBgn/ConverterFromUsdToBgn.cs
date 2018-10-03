using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterFromUsdToBgn
{
    class ConverterFromUsdToBgn
    {
        static void Main(string[] args)
        {
            var Usd = double.Parse(Console.ReadLine());
            var Bgn = Usd * 1.79549;
            Console.WriteLine("{0:f2} BGN", Bgn);
        }
    }
}
