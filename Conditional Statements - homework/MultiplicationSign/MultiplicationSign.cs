using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            double number1 = double.Parse(Console.ReadLine());
            double number2 = double.Parse(Console.ReadLine());
            double number3 = double.Parse(Console.ReadLine());

            if (number1 * number2 * number3 < 0)
            {
                Console.WriteLine("-");
            }
            else if (number1 * number2 * number3 == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("+");
            }
        }
    }
}
