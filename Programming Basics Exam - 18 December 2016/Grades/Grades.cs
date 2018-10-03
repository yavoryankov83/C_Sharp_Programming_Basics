using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Grades
    {
        static void Main(string[] args)
        {
            var studentsCount = int.Parse(Console.ReadLine());

            var countFrom2To3 = 0;
            var countFrom3To4 = 0;
            var countFrom4To5 = 0;
            var countFrom5To6 = 0;

            var sumOfGrades = 0.0;

            for (int i = 0; i < studentsCount; i++)
            {
                var grade = double.Parse(Console.ReadLine());

                sumOfGrades += grade;

                if (grade >=2 && grade < 3)
                {
                    countFrom2To3++;
                }
                else if (grade >= 3 && grade < 4)
                {
                    countFrom3To4++;
                }
                else if (grade >= 4 && grade < 5)
                {
                    countFrom4To5++;
                }
                else
                {
                    countFrom5To6++;
                }
            }
            Console.WriteLine("Top students: {0:f2}%", ((double)countFrom5To6 / studentsCount) * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", ((double)countFrom4To5 / studentsCount) * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", ((double)countFrom3To4 / studentsCount) * 100);
            Console.WriteLine("Fail: {0:f2}%", ((double)countFrom2To3 / studentsCount) * 100);
            Console.WriteLine("Average: {0:f2}", sumOfGrades / studentsCount);
        }
    }
}
