using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bills
{
    class Bills
    {
        static void Main(string[] args)
        {
            var months = int.Parse(Console.ReadLine());

            var billPerWater = 20 * months;
            var billPerInternet = 15 * months;

            var billPerTok = 0.0;
            var others = 0.0;


            for (int i = 0; i < months; i++)
            {
                var billPerElectricity = double.Parse(Console.ReadLine());
                others += (billPerElectricity + 20 + 15) + ((billPerElectricity + 20 + 15) * 0.2);
                billPerTok += billPerElectricity;
            }
            Console.WriteLine("Electricity: {0:f2} lv", billPerTok);
            Console.WriteLine("Water: {0:f2} lv", billPerWater);
            Console.WriteLine("Internet: {0:f2} lv", billPerInternet);
            Console.WriteLine("Other: {0:f2} lv", others);
            Console.WriteLine("Average: {0:f2} lv", ((billPerTok + billPerWater + billPerInternet + others) / months));
        }
    }
}
