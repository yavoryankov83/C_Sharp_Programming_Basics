using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadKey
{
    class ReadKey
    {
        static void Main(string[] args)
        {
            var key = Console.ReadKey();
            Console.WriteLine("Key name: " + key.Key);
            Console.WriteLine("Key number: " + (int)key.Key);
            Console.WriteLine("Spesial keys: {0} ", key.Modifiers);
            Console.WriteLine("Charecter entered: " + key.KeyChar);
        }
    }
}
