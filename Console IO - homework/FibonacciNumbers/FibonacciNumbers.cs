using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine()); //read

            if (N == 1) //chek if N = 1, the only member of sequence is 0
            {
                Console.WriteLine(0); //print
                return; //use to terminate the program if N = 1
            }

            long first = 0; // declare variable - the first number of the sequence - it is always 0
            long second = 1; // declare variable - the second number of the sequence - it is always 1
            long third; //declare the third number of the sequence

            Console.Write("{0}, {1}", first, second); // print first two members

            for (int i = 2; i < N; i++) //loop for the other members from next member - 2 to the last - N
            {
                third = first + second; //formula for the next member
                Console.Write(", {0}", third); //print the next member
                first = second; //change members - first get the value of second
                second = third; //change members - second get the value of third
            }
            Console.WriteLine(); //print
        }
    }
}
