using System;

class IntDoubleString
{
    static void Main(string[] args)
    {
        Console.WriteLine("integer for int, real for double, string for string!");
        string a = Console.ReadLine();

        switch (a)
        {
            case "integer": int b = int.Parse(Console.ReadLine()); bool isB = b > -1000 && b < 1000; if (isB) Console.WriteLine(b + 1); else Console.WriteLine("wrong"); break;
            case "real": double c = double.Parse(Console.ReadLine()); bool isC = c > -1000 && c < 1000; if (isC) Console.WriteLine("{0:f2}",c + 1.00); else Console.WriteLine("wrong"); break;
            case "string": string d = Console.ReadLine(); Console.WriteLine(d + "*"); break;
            default: Console.WriteLine("INCORECT INPUT DETAILS"); break;

                //Console.WriteLine("Enter your choise here: \n integer \n real \n text");
                //int choise = int.Parse(Console.ReadLine());
                //switch (choise)
                //{
                //    case 1:
                //        Console.Write("Please enter a integer: ");
                //        int a = int.Parse(Console.ReadLine());
                //        bool isA = a > -1000 && a < 1000;
                //        Console.WriteLine(isA ? "{0}, a" + 1 : "invalid");
                //        break;
                //    case 2:
                //        Console.Write("Please enter a real: ");
                //        double b = double.Parse(Console.ReadLine());
                //        bool isB = b > -1000 && b < 1000;
                //        Console.WriteLine(isB ? "{0:f2}, b" + 1.00 : "invalid");
                //        break;
                //    case 3:
                //        Console.Write("Please enter a string: ");
                //        string c = Console.ReadLine();
                //        Console.WriteLine(c + "*");
                //        break;
                //    default: Console.WriteLine("Not correct choice!"); break;
                //}
        }
    }
}
