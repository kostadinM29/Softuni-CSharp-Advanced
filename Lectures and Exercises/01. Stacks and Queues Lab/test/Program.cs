using System;
using System.Collections.Generic;

namespace _4. EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dict = new SortedDictionary<int,int>();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (dict.ContainsKey(num))
                {
                    dict[num]++;
                }
                if (!(dict.ContainsKey(num)))
                {
                    dict[num] = 1;
                }

            }
            foreach (var item in dict)
            {
                if (item.Value %2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}
