using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishLand
{
    class FishLand
    {
        static void Main(string[] args)
        {
            var skumriaPrice = double.Parse(Console.ReadLine());
            var cacaPrice = double.Parse(Console.ReadLine());
            var palamudQuantity = double.Parse(Console.ReadLine());
            var safridQuantity = double.Parse(Console.ReadLine());
            var midiQuantity = double.Parse(Console.ReadLine());

            var palamudPrice = skumriaPrice + skumriaPrice * 0.6;
            var safridPrice = cacaPrice + cacaPrice * 0.8;
            var midiPrice = 7.5;

            Console.WriteLine("{0:f2}", palamudPrice * palamudQuantity + safridPrice * safridQuantity + midiPrice * midiQuantity);
        }
    }
}
