using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine()); //read
            double b = double.Parse(Console.ReadLine()); //read
            double c = double.Parse(Console.ReadLine()); //read

            double x; //declare x
            double x1; //declare x1
            double discriminant = Math.Pow(b, 2) - (4 * a * c); //formula to find discriminant

            if (discriminant == 0) //check if discriminant = 0, there is one decision x = x1
            {
                x = x1 = ((-b) + Math.Sqrt(discriminant)) / (2 * a); //find x = x1
                Console.WriteLine("{0:F2}", x); //print
            }
            else if (discriminant > 0) //check if discriminant > 0, there is two different decisions x != x1
            {
                x = ((-b) + (Math.Sqrt(discriminant))) / (2 * a); //find x
                x1 = ((-b) - (Math.Sqrt(discriminant))) / (2 * a); //find x1
                Console.WriteLine("{0:F2}", Math.Min(x, x1)); //print
                Console.WriteLine("{0:F2}", Math.Max(x, x1)); //print
            }
            else if (discriminant < 0) //check if discriminant < 0, there is no roots
            {
                Console.WriteLine("no real roots"); //print
            }
        }
    }
}
