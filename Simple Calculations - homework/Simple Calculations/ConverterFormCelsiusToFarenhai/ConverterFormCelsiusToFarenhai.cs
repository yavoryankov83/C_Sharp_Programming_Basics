using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterFormCelsiusToFarenhai
{
    class ConverterFormCelsiusToFarenhai
    {
        static void Main(string[] args)
        {
            var celsius = double.Parse(Console.ReadLine());
            var farenhai = celsius * 1.8 + 32;
            Console.WriteLine("{0:f2}", farenhai);
        }
    }
}
