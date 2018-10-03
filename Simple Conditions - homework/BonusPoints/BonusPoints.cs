using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusPoints
{
    class BonusPoints
    {
        static void Main(string[] args)
        {
            var points = int.Parse(Console.ReadLine());
            var bonusPoints = 0.0;

            if (points <= 100)
            {
                bonusPoints = 5;
            }
            else if (points > 100 && points <= 1000)
            {
                bonusPoints = points * 0.2;
            }
            else if (points > 1000)
            {
                bonusPoints = points * 0.1;
            }
            if (points % 2 == 0)
            {
                bonusPoints += 1;
            }
            if (points % 10 == 5)
            {
                bonusPoints += 2;
            }
            Console.WriteLine(bonusPoints);
            Console.WriteLine(points + bonusPoints);
        }
    }
}
