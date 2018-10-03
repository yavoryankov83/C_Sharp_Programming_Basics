using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfIntervals
{
    class GameOfIntervals
    {
        static void Main(string[] args)
        {
            var moves = int.Parse(Console.ReadLine());
            var result = 0.0;
            var count1 = 0.0;
            var count2 = 0.0;
            var count3 = 0.0;
            var count4 = 0.0;
            var count5 = 0.0;
            var count6 = 0.0;

            for (int i = 0; i < moves; i++)
            {
                var nums = int.Parse(Console.ReadLine());

                if (nums >=0 && nums < 10)
                {
                    result += nums * 0.2;
                    count1++;
                }
                else if (nums >= 10 && nums < 20)
                {
                    result += nums * 0.3;
                    count2++;
                }
                else if (nums >= 20 && nums < 30)
                {
                    result += nums * 0.4;
                    count3++;
                }
                else if (nums >= 30 && nums < 40)
                {
                    result += 50;
                    count4++;
                }
                else if (nums >= 40 && nums <= 50)
                {
                    result += 100;
                    count5++;
                }
                else if (nums < 0 || nums > 50)
                {
                    result /= 2;
                    count6++;
                }
            }
            Console.WriteLine("{0:f2}", result);
            Console.WriteLine($"From 0 to 9: {(count1 / moves).ToString("0.00%")}");
            Console.WriteLine($"From 10 to 19: {(count2 / moves).ToString("0.00%")}");
            Console.WriteLine($"From 20 to 29: {(count3 / moves).ToString("0.00%")}");
            Console.WriteLine($"From 30 to 39: {(count4 / moves).ToString("0.00%")}");
            Console.WriteLine($"From 40 to 50: {(count5 / moves).ToString("0.00%")}");
            Console.WriteLine($"Invalid numbers: {(count6 / moves).ToString("0.00%")}");
        }
    }
}
