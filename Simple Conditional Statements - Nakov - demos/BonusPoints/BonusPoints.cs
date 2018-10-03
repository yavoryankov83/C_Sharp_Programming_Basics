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
            int points = int.Parse(Console.ReadLine());
            double bonusPoints = 0.0;
            if (points <= 100)
            {
                bonusPoints = 5;
            }
            else if (points > 100 && points <= 1000)
            {
                bonusPoints = (20 / 100.0) * points;
            }
            else if (points > 1000)
            {
                bonusPoints = (10 / 100.0) * points;
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
        }
    }
}
