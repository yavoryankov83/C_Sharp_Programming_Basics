using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());

            if (9 < score || score <= 0)
            {
                Console.WriteLine("invalid score");
            }
            else
            {
                if (1 <= score && score <= 3)
                {
                    score *= 10;
                }
                else if (4 <= score && score <= 6)
                {
                    score *= 100;
                }
                else if (7 <= score && score <= 9)
                {
                    score *= 1000;
                }
                Console.WriteLine(score);
            }
        }
    }
}
