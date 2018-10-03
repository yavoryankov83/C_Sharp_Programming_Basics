using System;

    class Rectangles
    {
        static void Main(string[] args)
        {
        float wight = float.Parse(Console.ReadLine());
        float height = float.Parse(Console.ReadLine());
        float area = wight * height;
        float perimetre = 2 * wight + 2 * height;
        Console.WriteLine(area.ToString("f2") + " " + perimetre.ToString("f2"));
        }
    }

