using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camp
{
    class Camp
    {
        static void Main(string[] args)
        {
            var groupsCount = int.Parse(Console.ReadLine());
            var studentsCount = 0;

            var carCount = 0.0;
            var microbusCount = 0.0;
            var smallbusCount = 0.0;
            var bigbusCount = 0.0;
            var trainCount = 0.0;

            var groups = new int[groupsCount];

            for (int i = 0; i < groups.Length; i++)
            {
                groups[i] = int.Parse(Console.ReadLine());

                studentsCount += groups[i];

                if (groups[i] <= 5)
                {
                    carCount += groups[i];
                }
                else if (groups[i] > 5 && groups[i] <= 12)
                {
                    microbusCount += groups[i];
                }
                else if (groups[i] > 12 && groups[i] <= 25)
                {
                    smallbusCount += groups[i];
                }
                else if (groups[i] > 25 && groups[i] <= 40)
                {
                    bigbusCount += groups[i];
                }
                else if (groups[i] > 40)
                {
                    trainCount += groups[i];
                }
            }
            Console.WriteLine("{0:f2}", carCount / studentsCount * 100);
            Console.WriteLine("{0:f2}", microbusCount / studentsCount * 100);
            Console.WriteLine("{0:f2}", smallbusCount / studentsCount * 100);
            Console.WriteLine("{0:f2}", bigbusCount / studentsCount * 100);
            Console.WriteLine("{0:f2}", trainCount / studentsCount * 100);
        }
    }
}
