using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintFirstAndLastName
{
    class PrintFirstAndLastName
    {
        static void Main(string[] args)
        {
            Console.Write("Enter yout first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter yout last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("{0} {1}", firstName, lastName);
        }
    }
}
