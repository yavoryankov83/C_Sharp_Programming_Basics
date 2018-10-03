using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareArea
{
    class SquareArea
    {
        static void Main(string[] args)
        {
            int side = int.Parse(Console.ReadLine());
            double SquareArea = Math.Pow(side, 2);
            Console.WriteLine(SquareArea);
        }
    }
}
