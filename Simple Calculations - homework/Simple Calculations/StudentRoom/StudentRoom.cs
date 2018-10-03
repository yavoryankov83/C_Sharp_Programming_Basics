using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRoom
{
    class StudentRoom
    {
        static void Main(string[] args)
        {
            var height = double.Parse(Console.ReadLine());
            var wide = double.Parse(Console.ReadLine());

            var row = Math.Floor(height / 1.2);
            var hall = 1;
            var column = Math.Floor((wide - hall) / 0.7);
            var workSpaceCount = row * column - 3;
            Console.WriteLine(workSpaceCount);
        }
    }
}
