using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForExam
{
    class OnTimeForExam
    {
        static void Main(string[] args)
        {
            var hourOfExam = int.Parse(Console.ReadLine());
            var minuteOfExam = int.Parse(Console.ReadLine());
            var hourOfArrival = int.Parse(Console.ReadLine());
            var minuteOfArrival = int.Parse(Console.ReadLine());

            var exam = hourOfExam * 60 + minuteOfExam;
            var arrival = hourOfArrival * 60 + minuteOfArrival;

            var diffHours = (Math.Abs(exam - arrival)) / 60;
            var diffMinutes = (Math.Abs(exam - arrival)) % 60;

            if (arrival <= exam && arrival >= exam - 30)
            {
                Console.WriteLine("On time");
                if (exam - arrival >= 1)
                {
                    Console.WriteLine("{0} minutes before the start", diffMinutes);
                }
            }
            else if (arrival < exam - 30)
            {
                Console.WriteLine("Early");
                if (exam - arrival >= 1 && diffHours >= 1)
                {
                    Console.WriteLine( diffMinutes <= 9 ? "{0}:0{1} hours before the start" : "{0}:{1} hours before the start", diffHours, diffMinutes);
                }
                else if (exam - arrival >= 1 && diffHours < 1)
                {
                    Console.WriteLine("{0} minutes before the start", diffMinutes);
                }
            }
            else if (arrival > exam)
            {
                Console.WriteLine("Late");
                if (Math.Abs(exam - arrival) >= 1 && diffHours >= 1)
                {
                    Console.WriteLine(diffMinutes <= 9 ? "{0}:0{1} hours after the start" : "{0}:{1} hours after the start", diffHours, diffMinutes);
                }
                else if (Math.Abs(exam - arrival) >= 1 && diffHours < 1)
                {
                    Console.WriteLine("{0} minutes after the start", diffMinutes);
                }
            }
        }
    }
}
