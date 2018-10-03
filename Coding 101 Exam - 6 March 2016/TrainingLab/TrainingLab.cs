using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingLab
{
    class TrainingLab
    {
        static void Main(string[] args)
        {
            var lenght = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var deskHeight = (height - 1) * 100;
            var deskCountPerRow = (int)deskHeight / 70;
            var deskCountPerCol = (int)(lenght * 100) / 120;

            var deskCount = deskCountPerRow * deskCountPerCol - 3;

            Console.WriteLine(deskCount);

        }
    }
}
