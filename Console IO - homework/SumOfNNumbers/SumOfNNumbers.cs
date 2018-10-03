using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()); //read
            double number; //declare variable for input three numbers
            double sum = 0; //declare variable for sum and give it value of 0

            for (int i = 0; i < N; i++) //make a for loop from 0 to N
            {
                number = double.Parse(Console.ReadLine()); //read three numbers
                sum += number; //keep and change the sum
            }
            Console.WriteLine(sum); //print
        }
    }
}
