using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] array;
            array = new int[n, n];
            int maxRotations = n * n;
            string direction = "right";
            int cow = 0;
            int row = 0;

            for (int i = 1; i <= maxRotations; i++)
            {
                if (direction == "right" && (cow > n - 1 || array[row, cow] != 0))
                {
                    direction = "down";
                    cow--;
                    row++;
                }
                if (direction == "down" && ((row > n - 1) || array[row, cow] != 0))
                {
                    direction = "left";
                    row--;
                    cow--;
                }
                if (direction == "left" && ((cow < 0) || array[row, cow] != 0))
                {
                    direction = "up";
                    cow++;
                    row--;
                }
                if (direction == "up" && ((cow < 0) || array[row, cow] != 0))
                {
                    direction = "right";
                    row++;
                    cow++;
                }

                array[row, cow] = i;

                if (direction == "right")
                {
                    cow++;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "left")
                {
                    cow--;
                }
                if (direction == "up")
                {
                    row--;
                }

            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
