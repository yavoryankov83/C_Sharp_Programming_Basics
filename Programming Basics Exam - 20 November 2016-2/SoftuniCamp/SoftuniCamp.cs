using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniCamp
{
    class SoftuniCamp
    {
        static void Main(string[] args)
        {
            var groupsCount = int.Parse(Console.ReadLine());

            var carCount = 0;
            var microbusCount = 0;
            var smallbusCount = 0;
            var bigbusCount = 0;
            var trainCount = 0;

            var count = 0.0;

            for (int i = 0; i < groupsCount; i++)
            {
                var peopleCount = int.Parse(Console.ReadLine());

                count += peopleCount;

                if (peopleCount <= 5)
                {
                    carCount += peopleCount;
                }
                else if (peopleCount >=6 && peopleCount <= 12)
                {
                    microbusCount += peopleCount;
                }
                else if (peopleCount >= 13 && peopleCount <= 25)
                {
                    smallbusCount += peopleCount;
                }
                else if (peopleCount >= 26 && peopleCount <= 40)
                {
                    bigbusCount += peopleCount;
                }
                else
                {
                    trainCount += peopleCount;
                }
            }
            Console.WriteLine((carCount / count).ToString("0.00%"));
            Console.WriteLine((microbusCount / count).ToString("0.00%"));
            Console.WriteLine((smallbusCount / count).ToString("0.00%"));
            Console.WriteLine((bigbusCount / count).ToString("0.00%"));
            Console.WriteLine((trainCount / count).ToString("0.00%"));
        }
    }
}
