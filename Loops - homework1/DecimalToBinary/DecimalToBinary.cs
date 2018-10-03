using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            long reminder;
            string dec = String.Empty;

            while (number > 0)
            {
                reminder = number % 2;
                number /= 2;
                dec = reminder.ToString() + dec;
            }
            Console.WriteLine(dec);


        }
    }
}
