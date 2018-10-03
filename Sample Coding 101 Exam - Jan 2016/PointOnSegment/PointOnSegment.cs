using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnSegment
{
    class PointOnSegment
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());

            var isInside = true;
            var smallDistance = int.MaxValue;
            var distance1 = Math.Abs(first - point);
            var distance2 = Math.Abs(second - point);

            if (distance1 <= distance2)
            {
                smallDistance = distance1;
            }
            else
            {
                smallDistance = distance2;
            }

            if (first < second)
            {
                isInside = point >= first && point <= second;

                if (isInside == true)
                {
                    Console.WriteLine("in");
                    Console.WriteLine(smallDistance);
                }
                else if (!(isInside) == true)
                {
                    Console.WriteLine("out");
                    Console.WriteLine(smallDistance);
                }
            }
            else if (first > second)
            {
                isInside = point >= second && point <= first;

                if (isInside == true)
                {
                    Console.WriteLine("in");
                    Console.WriteLine(smallDistance);
                }
                else if (!(isInside) == true)
                {
                    Console.WriteLine("out");
                    Console.WriteLine(smallDistance);
                }
            }
        }
    }
}
