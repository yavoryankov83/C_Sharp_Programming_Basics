using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchesToCentimeters
{
    class InchesToCentimeters
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double centimeters = 2.54 * inches;
            Console.WriteLine(centimeters);
        }
    }
}
