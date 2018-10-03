﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInFigure
{
    class PointInFigure
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var inside1 = x >= 2 && x < 4 && y >= -3 && y <= 1;
            var inside2 = x > 10 && x <= 12 && y >= -3 && y <= 1;
            var inside3 = x >= 4 && x <= 10 && y >= -5 && y <= 3;

            if (inside1 || inside2 || inside3)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }
        }
    }
}
