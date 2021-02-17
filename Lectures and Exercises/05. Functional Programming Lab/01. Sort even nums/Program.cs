using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sort_even_nums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(", ").Select((number) => { return int.Parse(number); }).Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            Console.WriteLine(String.Join(", ", nums));
        }
    }
}
