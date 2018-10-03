using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntDoubleString
{
    class IntDoubleString
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();

            //switch (input)
            //{
            //    case "integer": int a = int.Parse(Console.ReadLine()); Console.WriteLine(a + 1); break;
            //    case "real": double b = double.Parse(Console.ReadLine()); Console.WriteLine("{0:F2}", b + 1); break;
            //    case "text": string str = Console.ReadLine(); Console.WriteLine(str + "*"); break;
            //}

            string input = Console.ReadLine();

            if (input == "integer")
            {
                int integer = int.Parse(Console.ReadLine());
                Console.WriteLine(integer + 1);
            }
            if (input == "real")
            {
                double real = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", real + 1);
            }
            if (input == "text")
            {
                string text = Console.ReadLine();
                Console.WriteLine(text + "*");
            }
        }
    }
}
