using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()); //1. read the number from the console
            int digit = N / 100; //2. take the number without the last two digits
            int thirdDigit = digit % 10; //4. make a variable to keep te third digit
            if (digit % 10 == 7) //3. take the third digit and check if it is equal to 7
            {
                Console.WriteLine("true"); //print
            }
            else
            {
                Console.WriteLine("false" + " " + thirdDigit); //print
            }
        }
    }
}
