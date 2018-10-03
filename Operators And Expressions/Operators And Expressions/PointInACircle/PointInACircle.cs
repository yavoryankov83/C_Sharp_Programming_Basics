using System;

    class PointInACircle
    {
        static void Main(string[] args)
        {
        float x = float.Parse(Console.ReadLine());
        float y = float.Parse(Console.ReadLine());
        bool inCircle = (x - 0) * (x - 0) + (y - 0) * (y - 0) <= 4; // formula za triugulnik
        //  bool inCircle = (((xPoint - xCircle) * (xPoint - xCircle)) + ((yPoint - yCircle) * (yPoint - yCircle))) <= (radius * radius);
        // bool outRec = ((xPoint >= xRec) && (xPoint <= (xRec + widthRec))) && ((yPoint <= yRec) && (yPoint >= (yPoint - heightRec)));
        if (inCircle && y > 0)
        {
            Console.WriteLine("no");
        }
        else
        {
            Console.WriteLine("yes");
        }
    }
    }

