using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOfNStars
{
    class TriangleOfNStars
    {
        static void Main(string[] args)
        {
            int stars = int.Parse(Console.ReadLine());

            for (int i = 0; i < stars; i++)
            {
                Console.WriteLine(new string('*', stars));
            }
        }
    }
}
