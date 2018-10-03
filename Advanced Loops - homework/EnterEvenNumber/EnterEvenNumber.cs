using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterEvenNumber
{
    class EnterEvenNumber
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine();
            int num;
            bool find = int.TryParse(str, out num);

            while (find == false || num % 2 != 0)
            {
                Console.WriteLine("Invalid number!");
                Console.Write("Enter even number: ");
                str = Console.ReadLine();
                int nums;
                bool find1 = int.TryParse(str, out nums);
                if (find1 == true && nums % 2 == 0)
                {
                    Console.WriteLine("Even number entered: {0}", nums);
                    return;
                }
            }
            Console.WriteLine("Even number entered: {0}", num);
        }
    }
}
