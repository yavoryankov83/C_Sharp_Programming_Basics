using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            long dec = 0;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[number.Length - i - 1] == '0')
                {
                    continue;
                }
                else
                {
                    dec += (long)Math.Pow(2, i);
                }
            }
            Console.WriteLine(dec);
        }
    }
}
