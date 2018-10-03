using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSegment
{
    class PointOfSegment
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());

            bool inside = true;
            var minDistance = int.MaxValue;

            if (first <= second)
            {           
                inside = point >= first && point <= second;
                var distance1 = Math.Abs(point - first);
                var distance2 = Math.Abs(point - second);

                if (distance1 <= distance2)
                {
                    minDistance = distance1;
                }
                else
                {
                    minDistance = distance2;
                }
            }
            else
            {
                inside = point >= second && point <= first;
                var distance1 = Math.Abs(point - first);
                var distance2 = Math.Abs(point - second);

                if (distance1 <= distance2)
                {
                    minDistance = distance1;
                }
                else
                {
                    minDistance = distance2;
                }
            }

            if (inside)
            {
                Console.WriteLine("in");
                Console.WriteLine(minDistance);
            }
            else
            {
                Console.WriteLine("out");
                Console.WriteLine(minDistance);
            }
            
        }
    }
}
