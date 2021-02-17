using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sum_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(", ").Select(ParseNumber).ToList();
            PrintResults(list, Count, Sum);
        }

        static int Count(List<int> list)
        {
            return list.Count;
        }
        static int Sum(List<int> list)
        {
            return list.Sum();
        }
        static void PrintResults(List<int> list, Func<List<int>, int> count, Func<List<int>, int> sum)
        {
            Console.WriteLine(count(list));
            Console.WriteLine(sum(list));
        }
        static int ParseNumber(string number)
        {
            return int.Parse(number);
        }
    }
}
