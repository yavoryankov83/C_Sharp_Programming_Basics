using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Buses
{
    class Task2Buses
    {
        static void Main(string[] args)
        {
            int busses = int.Parse(Console.ReadLine());
            int groups = 0;
            int groupSpeed = int.MaxValue;

            for (int i = 0; i < busses; i++)
            {
                int busSpeed = int.Parse(Console.ReadLine());
                if (busSpeed <= groupSpeed)
                {
                    groups++;
                    groupSpeed = busSpeed;
                }
            }
            Console.WriteLine(groups);
        }
    }
}

