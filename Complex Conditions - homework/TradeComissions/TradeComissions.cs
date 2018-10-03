using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComissions
{
    class TradeComissions
    {
        static void Main(string[] args)
        {
            var town = Console.ReadLine();
            var sales = double.Parse(Console.ReadLine());

            var comission = - 1.0;

            if (town == "Sofia")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = sales * 0.05;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = sales * 0.07;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = sales * 0.08;
                }
                else if (sales > 10000)
                {
                    comission = sales * 0.12;
                }
            }
            else if (town == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = sales * 0.045;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = sales * 0.075;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = sales * 0.1;
                }
                else if (sales > 10000)
                {
                    comission = sales * 0.13;
                }
            }
            else if (town == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comission = sales * 0.055;
                }
                else if (sales > 500 && sales <= 1000)
                {
                    comission = sales * 0.08;
                }
                else if (sales > 1000 && sales <= 10000)
                {
                    comission = sales * 0.12;
                }
                else if (sales > 10000)
                {
                    comission = sales * 0.145;
                }
            }
            Console.WriteLine(comission <= -1 ? "error" : "{0:f2}", comission);
        }
    }
}
