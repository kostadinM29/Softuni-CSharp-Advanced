using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._fast_food
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            List<int> orders = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            Queue<int> queue = new Queue<int>(orders);

            Console.WriteLine(queue.Max());
            for (int i = 0; i < orders.Count; i++)
            {
                if (food >= queue.Peek())
                {
                    food -= queue.Dequeue();
                }
            }
            if (food >= 0 && queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write("Orders left: ");
                Console.Write(string.Join(" ", queue));
            }
        }
    }
}
