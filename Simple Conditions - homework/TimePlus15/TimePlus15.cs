using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15
{
    class TimePlus15
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minute = int.Parse(Console.ReadLine());

            var result = hour * 60 + minute + 15;
            var hours = result / 60;
            var minutes = result % 60;

            string m = "";

            if (hours >= 24)
            {
                hours =  Math.Abs(24 - hours);
            }
            if (minutes < 10)
            {
                m = minutes.ToString().PadLeft(2, '0');
            }
            Console.WriteLine( minutes >= 10 ? $"{hours}:{minutes}" : $"{hours}:{m}");
        }
    }
}
