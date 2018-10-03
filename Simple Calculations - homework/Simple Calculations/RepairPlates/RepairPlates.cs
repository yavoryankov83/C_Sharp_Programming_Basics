using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairPlates
{
    class RepairPlates
    {
        static void Main(string[] args)
        {
            var squareSide = int.Parse(Console.ReadLine());
            var widthPlate = double.Parse(Console.ReadLine());
            var lengthPlate = double.Parse(Console.ReadLine());
            var widthBenge = int.Parse(Console.ReadLine());
            var lengthBenge = int.Parse(Console.ReadLine());

            var time = 0.2;
            var squareArea = Math.Pow(squareSide, 2);
            var bengeArea = lengthBenge * widthBenge;
            var plateArea = lengthPlate * widthPlate;
            var plateCount = (squareArea - bengeArea) / plateArea;
            var timeCount = plateCount * time;

            Console.WriteLine(plateCount);
            Console.WriteLine(timeCount);
        }
    }
}
