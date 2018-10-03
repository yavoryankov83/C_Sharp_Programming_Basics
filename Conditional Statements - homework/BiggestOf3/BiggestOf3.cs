using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestOf3
{
    class BiggestOf3
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            //Console.WriteLine(Math.Max((Math.Max(a, b)), c));

            if (a >= b && a >= c)
            {
                Console.WriteLine(a);
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
}
