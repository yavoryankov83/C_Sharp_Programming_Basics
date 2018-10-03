using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersOperations
{
    class NumbersOperations
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var operation = Console.ReadLine();

            var result = 0.0;

            if (operation == "+")
            {
                result = num1 + num2;
                Console.WriteLine(result % 2 == 0 ? $"{num1} {operation} {num2} = {result} - even" : $"{num1} {operation} {num2} = {result} - odd");
            }
            else if (operation == "-")
            {
                result = num1 - num2;
                Console.WriteLine(result % 2 == 0 ? $"{num1} {operation} {num2} = {result} - even" : $"{num1} {operation} {num2} = {result} - odd");
            }
            else if (operation == "*")
            {
                result = num1 * num2;
                Console.WriteLine(result % 2 == 0 ? $"{num1} {operation} {num2} = {result} - even" : $"{num1} {operation} {num2} = {result} - odd");
            }
            else if (operation == "/")
            {
                if (num2 != 0)
                {
                    result = (double)num1 / num2;
                    Console.WriteLine("{0} {1} {2} = {3:f2}", num1, operation, num2, result);
                }
                else
                {
                    Console.WriteLine("Cannot divide {0} by zero", num1);
                }
            }
            else if (operation == "%")
            {
                if (num2 != 0)
                {
                    result = num1 % num2;
                    Console.WriteLine("{0} {1} {2} = {3}", num1, operation, num2, result);
                }
                else
                {
                    Console.WriteLine("Cannot divide {0} by zero", num1);
                }
            }
        }
    }
}
