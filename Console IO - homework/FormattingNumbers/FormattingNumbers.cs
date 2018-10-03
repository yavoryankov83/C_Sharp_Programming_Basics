using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            
            int a = int.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            Console.Write("{0,-10:X}", a);
            Console.Write(Convert.ToString(a, 2).PadLeft(10, '0'));
            Console.Write("{0,10:F2}", b);
            Console.Write("{0,-10:F3}", c);
        }
    }
}
