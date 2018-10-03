using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "Yavor";
            string lastName = "Yankov";
            byte age = 32;
            char gender = 'm';
            ulong personalID = 8306112507;
            uint employeeNumber = 27569999;
            Console.WriteLine("{0} {1}, {2}, {3}, {4}, {5}.", firstName, lastName, age, gender, personalID, employeeNumber);
        }
    }
}
