using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolleyBall
{
    class VolleyBall
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine();
            var holidays = int.Parse(Console.ReadLine());
            var weekendsToBornTown = int.Parse(Console.ReadLine());

            double play = 0;

            var weekendsToSofia = 48 - weekendsToBornTown;
            double holidaysToPlaySofia = holidays * (2 / 3.0);
            double weekendsForPlayingSofia = weekendsToSofia * (3 / 4.0);
            double allPlay = weekendsForPlayingSofia + holidaysToPlaySofia + weekendsToBornTown;

            if (year == "normal")
            {
                play = allPlay;
            }
            else if (year == "leap")
            {
                play = allPlay + (allPlay * 0.15);
            }
            Console.WriteLine("{0}", Math.Truncate(play));
        }
    }
}
