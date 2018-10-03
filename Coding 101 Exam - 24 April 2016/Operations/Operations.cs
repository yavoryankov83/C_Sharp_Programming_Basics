using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Operations
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var opr = Console.ReadLine();
            var result = 0.0;

            if (opr == "+")
            {
                result = num1 + num2;
                Console.WriteLine(result % 2 == 0 ? $"{num1} {opr} {num2} = {result} - even" : $"{num1} {opr} {num2} = {result} - odd");
            }
            else if (opr == "-")
            {
                result = num1 - num2;
                Console.WriteLine(result % 2 == 0 ? $"{num1} {opr} {num2} = {result} - even" : $"{num1} {opr} {num2} = {result} - odd");
            }
            else if (opr == "*")
            {
                result = num1 * num2;
                Console.WriteLine(result % 2 == 0 ? $"{num1} {opr} {num2} = {result} - even" : $"{num1} {opr} {num2} = {result} - odd");
            }
            else if (opr == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    result = (double)num1 / num2;
                    Console.WriteLine("{0} / {1} = {2:f2}", num1, num2, result);
                }
            }
            else
            {
                if (num2 == 0)
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
                else
                {
                    result = num1 % num2;
                    Console.WriteLine($"{num1} % {num2} = {result}");
                }
            }
        }
    }
}
