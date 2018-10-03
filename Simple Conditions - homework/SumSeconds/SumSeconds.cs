using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
    class SumSeconds
    {
        static void Main(string[] args)
        {
            var firstRunner = int.Parse(Console.ReadLine());
            var secondRunner = int.Parse(Console.ReadLine());
            var thirdRunner = int.Parse(Console.ReadLine());

            int sum = firstRunner + secondRunner + thirdRunner;

            int minutes = sum / 60;
            int seconds = sum % 60;

            Console.WriteLine(seconds < 10 ? $"{minutes}:0{seconds}": $"{minutes}:{seconds}");
        }
    }
}
