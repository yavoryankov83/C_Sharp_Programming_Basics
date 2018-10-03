using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOf55Stars
{
    class TriangleOf55Stars
    {
        static void Main(string[] args)
        {
            //int stars = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++) //stars
            {
                Console.WriteLine(new string('*', i));
            }
        }
    }
}
