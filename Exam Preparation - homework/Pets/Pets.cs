using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Pets
    {
        static void Main(string[] args)
        {
            var days = int.Parse(Console.ReadLine());
            var food = int.Parse(Console.ReadLine());
            var foodDog = double.Parse(Console.ReadLine());
            var foodCat = double.Parse(Console.ReadLine());
            var foodTortouse = double.Parse(Console.ReadLine());

            var foodEatenByDog = days * foodDog;
            var foodEatenByCat = days * foodCat;
            var foodEatenByTortouse = (days * foodTortouse) / 1000;

            var AllEatenFood = foodEatenByDog + foodEatenByCat + foodEatenByTortouse;

            if (AllEatenFood <= food)
            {
                Console.WriteLine("{0} kilos of food left", Math.Floor(food - AllEatenFood));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed", Math.Ceiling(AllEatenFood - food));
            }
        }
    }
}
