﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            var x1 = int.Parse(Console.ReadLine());
            var y1 = int.Parse(Console.ReadLine());
            var x2 = int.Parse(Console.ReadLine());
            var y2 = int.Parse(Console.ReadLine());
            var x3 = int.Parse(Console.ReadLine());
            var y3 = int.Parse(Console.ReadLine());

            var side = Math.Abs(x2 - x3);
            var height = Math.Abs(y1 - y2);

            var area = (side * height) / 2.0;
            Console.WriteLine(area);
        }
    }
}
