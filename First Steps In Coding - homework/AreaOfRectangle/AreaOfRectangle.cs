using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfRectangle
{
    class AreaOfRectangle
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int AreaOfRectangle = sideA * sideB;
            Console.WriteLine(AreaOfRectangle);
        }
    }
}
