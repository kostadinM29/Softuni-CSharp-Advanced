using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._basic_queue_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> queueInput = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Queue<int> queue = new Queue<int>();
            for (int i = 0; i < input[0]; i++)
            {
                queue.Enqueue(queueInput[i]);
            }
            for (int i = 0; i < input[1]; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                if (queue.Contains(input[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }
            }
        }
    }
}
