using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var cols = int.Parse(Console.ReadLine());

            double income = rows * cols;

            if (type == "Premiere")
            {
                income = income * 12;
            }
            else if (type == "Normal")
            {
                income = income * 7.5;
            }
            else if (type == "Discount")
            {
                income = income * 5;
            }
            Console.WriteLine("{0:f2} leva", income);
        }
    }
}
