using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCamp
{
    class SoftUniCamp
    {
        static void Main(string[] args)
        {
            var groupsCount = int.Parse(Console.ReadLine());

            var carCount = 0;
            var microbusCount = 0;
            var smallbusCount = 0;
            var bigbisCount = 0;
            var trainCount = 0;
            var allCount = 0.0;

            for (int i = 0; i < groupsCount; i++)
            {
                var peopleCount = int.Parse(Console.ReadLine());

                if (peopleCount < 6)
                {
                    carCount+= peopleCount;
                }
                else if (peopleCount >= 6 && peopleCount < 13)
                {
                    microbusCount+= peopleCount;
                }
                else if (peopleCount >= 13 && peopleCount < 26)
                {
                    smallbusCount+= peopleCount;
                }
                else if (peopleCount >= 26 && peopleCount < 41)
                {
                    bigbisCount+= peopleCount;
                }
                else
                {
                    trainCount+= peopleCount;
                }
            }
            allCount = carCount + microbusCount + smallbusCount + bigbisCount + trainCount;
            Console.WriteLine((carCount / allCount).ToString("0.00%"));
            Console.WriteLine((microbusCount / allCount).ToString("0.00%"));
            Console.WriteLine((smallbusCount / allCount).ToString("0.00%"));
            Console.WriteLine((bigbisCount / allCount).ToString("0.00%"));
            Console.WriteLine((trainCount / allCount).ToString("0.00%"));
        }
    }
}
