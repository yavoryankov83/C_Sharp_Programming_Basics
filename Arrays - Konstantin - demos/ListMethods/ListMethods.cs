using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMethods
{
    class ListMethods
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 2, 5, 23, 45, -45, 38, 0 };

            list.RemoveAll((x) => x < 2);
            Console.WriteLine(string.Join(":", list));
            list.Add(666);
            list.Sort();
            list.RemoveAt(2);
            list.RemoveRange(2, 3);
            list.Remove(5);
            list.Insert(0, 789);
            list.TrimExcess();
            list.Count();
            Console.WriteLine(list.Capacity);
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
