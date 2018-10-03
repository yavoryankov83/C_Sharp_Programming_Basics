using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class SpecialNumbers
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                bool special = true;
                var num = i;

                for (int j = 0; j < 4; j++)
                {
                    var digit = num % 10;
                    num /= 10;
                    if (digit == 0)
                    {
                        special = false;
                        break;
                    }
                    if (n % digit != 0)
                    {
                        special = false;
                    }
                }
                if (special == true)
                {
                    Console.Write("{0} ", i);
                }
            }
        }
    }
}
