﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Circle
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());
            double perimeter = Math.PI * (2 * radius);
            double area = Math.PI * (radius * radius);
            Console.WriteLine("{0:f2} {1:f2}", perimeter, area);
        }
    }
}
