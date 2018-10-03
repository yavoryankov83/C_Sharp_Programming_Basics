using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoonGravity
{
    class MoonGravity
    {
        static void Main(string[] args)
        {
            double weightOnEarth = double.Parse(Console.ReadLine()); //1. read fron the console
            double weightOnMoon = weightOnEarth * (17 / 100D); //2. find the weightOnMoom
            Console.WriteLine("{0:F3}", weightOnMoon); //precision with placeholder
            //Console.WriteLine(Math.Round(weightOnMoon, 3)); //print /precision using Math.Round
        }
    }
}
