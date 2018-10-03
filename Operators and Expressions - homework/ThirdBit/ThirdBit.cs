using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdBit
{
    class ThirdBit
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine()); //1. read from the console

            int index = 3; //2. declare variable for the gven index ot bit

            //int mask = 1 << index; //3. declare a mask with one position left
            //int numberMask = number & mask; //4. declare number mask
            //int bit = numberMask >> index; //5. fint bit

            //Console.WriteLine(bit); //print

            // second variant
           
            Console.WriteLine((number >> index) & 1); //1. use the formula to fint bit in position index of given number -  (number >> index) & 1print and print
        }
    }
}
