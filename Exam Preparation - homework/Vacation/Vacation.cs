using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Vacation
    {
        static void Main(string[] args)
        {
            var oldPeople = int.Parse(Console.ReadLine());
            var students = int.Parse(Console.ReadLine());
            var nights = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();

            double studentsPrice;
            double oldPeoplePrice;
            var sum = 0.0;

            var nightsPrice = nights * 82.99;

            if (transport == "train")
            {
                studentsPrice = students * 14.99 * 2;
                oldPeoplePrice = oldPeople * 24.99 * 2;

                if (students + oldPeople >= 50)
                {
                    studentsPrice = studentsPrice / 2;
                    oldPeoplePrice = oldPeoplePrice / 2;
                }
            }
            else if (transport == "bus")
            {
                studentsPrice = students * 28.50 * 2;
                oldPeoplePrice = oldPeople * 32.50 * 2;
            }
            else if (transport == "ship")
            {
                studentsPrice = students * 39.99 * 2;
                oldPeoplePrice = oldPeople * 42.99 * 2;
            }
            else
            {
                studentsPrice = students * 50 * 2;
                oldPeoplePrice = oldPeople * 70 * 2;
            }
            sum = (nightsPrice + studentsPrice + oldPeoplePrice) + (nightsPrice + studentsPrice + oldPeoplePrice) * 0.1;
            Console.WriteLine("{0:f2}", sum);
        }
    }
}
