using System;

    class PointCircleRectangle
    {
        static void Main(string[] args)
        {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        bool inCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= (1.5 * 1.5);
        bool outRectangle = (x < -1 || x > 5) && (y < -1 || y > 1);

        if ((inCircle = true) && (outRectangle = true))
        {
            Console.WriteLine("inside circle" + " " + "outside rectangle");
        }
        if ((inCircle = true) && (outRectangle = !true))
        {
            Console.WriteLine("inside circle" + " " + "inside rectangle");
        }
        if ((inCircle = !true) && (outRectangle = true))
        {
            Console.WriteLine("outside circle" + " " + "outside rectangle");
        }
        if ((inCircle = !true) && (outRectangle = !true))
        {
            Console.WriteLine("outside circle" + " " + "inside rectangle");
        }
        }
    }

