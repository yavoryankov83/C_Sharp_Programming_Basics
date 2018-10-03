using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Exam
    {
        static void Main(string[] args)
        {
            var startHour = int.Parse(Console.ReadLine());
            var startMinute = int.Parse(Console.ReadLine());
            var arrivedHour = int.Parse(Console.ReadLine());
            var arrivedMinute = int.Parse(Console.ReadLine());

            var diff = (startHour * 60 + startMinute) - (arrivedHour * 60 + arrivedMinute);

            if (diff >= 0 && diff <= 30)
            {
                Console.WriteLine("On time");
                if (diff >= 1)
                {
                    Console.WriteLine($"{diff} minutes before the start");
                }
            }
            else if (diff > 30)
            {
                Console.WriteLine("Early");
                if (diff < 60)
                {
                    Console.WriteLine($"{diff} minutes before the start");
                }
                else
                {
                    Console.WriteLine($"{diff / 60}:{(diff % 60).ToString("00")} hours before the start");
                }
            }
            else if (diff < 0)
            {
                Console.WriteLine("Late");
                if (Math.Abs(diff) >= 1)
                {
                    if (Math.Abs(diff) < 60)
                    {
                        Console.WriteLine($"{Math.Abs(diff)} minutes after the start");
                    }
                    else
                    {
                        Console.WriteLine($"{Math.Abs(diff) / 60}:{(Math.Abs(diff) % 60).ToString("00")} hours after the start");
                    }
                }
            }
        }
    }
}
