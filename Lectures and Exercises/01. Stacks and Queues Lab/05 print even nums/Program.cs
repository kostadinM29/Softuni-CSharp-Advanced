using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_print_even_nums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>(nums);
            List<string> finalNums = new List<string>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (queue.Peek() % 2 == 0)
                {
                    int num = queue.Dequeue();
                    finalNums.Add(num.ToString());
                }
                else
                {
                    queue.Dequeue();
                }
            }
            Console.WriteLine(string.Join(", ", finalNums));
        }
    }
}
