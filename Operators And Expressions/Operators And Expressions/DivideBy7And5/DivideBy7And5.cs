using System;

class DivideBy7And5
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        //Console. WriteLine((num % 7 == 0) && (num % 5 == 0) ? "true NUMBER" : "false NUMBER");
        bool result = (num % 7 == 0) && (num % 5 == 0);
        if (result == true)
        {
            Console.WriteLine("true" + " " + num);
        }
        else
        {
            Console.WriteLine("false" + " " + num);
        }
    }
}

