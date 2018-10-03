using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfExecellent
{
    class CheckIfExecellent
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            var mark = double.Parse(Console.ReadLine());

            if (mark >= 5.5)
            {
                Console.WriteLine("Excellent!");
            }
        }
    }
}
