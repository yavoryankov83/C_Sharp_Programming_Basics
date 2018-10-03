using System;

class ComparingFloats
{
    static void Main(string[] args)
    {
        double a = (double.Parse(Console.ReadLine()));
        double b = (double.Parse(Console.ReadLine()));
        //bool equalAB = Math.Abs(a - b) < 0.000001;
        //Console.WriteLine(equalAB ? true : false);
        if (Math.Abs(a - b) < 0.000001)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}


