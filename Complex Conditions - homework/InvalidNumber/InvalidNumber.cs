using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvalidNumber
{
    class InvalidNumber
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            bool isValid = (number >= 100 && number <= 200) || number == 0;

            if (isValid == false)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
