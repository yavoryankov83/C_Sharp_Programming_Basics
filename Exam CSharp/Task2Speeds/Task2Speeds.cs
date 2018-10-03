using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Speeds
{
    class Task2Speeds
    {
        static void Main(string[] args)
        {
            int cars = int.Parse(Console.ReadLine());

            bool isFirst = true;

            int groupSpeed = int.MaxValue;
            int groups = 0;

            int bestSum = 0;
            int bestLenght = 0;

            int currentSum = 0;
            int currentLenght = 0;

            bool isUpdated = false;

            for (int i = 0; i < cars; i++)
            {
                int carSpeed = int.Parse(Console.ReadLine());
                isUpdated = false;
                if (isFirst)
                {
                    isFirst = false;
                    groupSpeed = carSpeed;
                    currentLenght = 1;
                    currentSum = carSpeed;
                }
                else if (carSpeed <= groupSpeed)
                {
                    groups++;
                    groupSpeed = carSpeed;
                    if (currentLenght > bestLenght)
                    {
                        bestLenght = currentLenght;
                        bestSum = currentSum;
                    }
                    else if (currentLenght == bestLenght)
                    {
                        bestSum = (bestSum > currentSum) ? bestSum : currentSum;
                    }
                    currentSum = carSpeed;
                    currentLenght = 1;
                }
                else
                {
                    ++currentLenght;
                    currentSum += carSpeed;
                }
            }
            if (!isUpdated)
            {
                if (currentLenght > bestLenght)
                {
                    bestSum = currentSum;
                    bestLenght = currentLenght;
                }
                else if (currentLenght == bestLenght)
                {
                    bestSum = (bestSum > currentSum) ? bestSum : currentSum;
                }
            }
            Console.WriteLine(bestSum);
        }
    }
}
