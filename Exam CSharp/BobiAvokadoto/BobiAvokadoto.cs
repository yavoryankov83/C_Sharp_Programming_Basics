using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobiAvokadoto
{
    class BobiAvokadoto
    {
        static void Main(string[] args)
        {
            uint head = uint.Parse(Console.ReadLine());
            uint combs = uint.Parse(Console.ReadLine());

            uint bestTooth = 0;
            uint bestComb = 0;

            for (uint i = 0; i < combs; i++)
            {
                uint comb = uint.Parse(Console.ReadLine());
                //check if comb is valid
                if ((head & comb) == 0)
                {
                    //count teeth - declare a variable - currentTooth
                    uint currentTooth = 0;

                    for (int j = 0; j < 32; j++)
                    {
                        currentTooth += ((comb >> j) & 1);
                    }
                    //check if currentTooth is bestTooth
                    if (currentTooth > bestTooth)
                    {
                        //if currentTooth is > bestTooth, then initialize bestTooth with value of currentTooth
                        bestTooth = currentTooth;
                        //then bestComb = current comb, which is comb
                        bestComb = comb;
                    }
                }
            }
            Console.WriteLine(bestComb);
        }
    }
}
