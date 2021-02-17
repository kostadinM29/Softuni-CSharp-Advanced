using System;
using System.Collections.Generic;
using System.Linq;

namespace exam_25._10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input1 = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> input2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int taskToKill = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>(input1);
            Queue<int> queue = new Queue<int>(input2);

            int killer = 0;

            bool threatDead = false;
            while (!threatDead)
            {
                int thread = queue.Peek();
                int task = stack.Peek();

                if (thread >= task)
                {
                    if (taskToKill == task)
                    {
                        killer = thread;
                        threatDead = true;
                    }
                    else
                    {
                        queue.Dequeue();
                        stack.Pop();
                    }
                }
                if (thread < task)
                {
                    if (taskToKill == task)
                    {
                        killer = thread;
                        threatDead = true;
                    }
                    else
                    {
                        queue.Dequeue();
                    }
                }
            }
            Console.WriteLine($"Thread with value {killer} killed task {taskToKill}");
            Console.WriteLine(string.Join(" ",queue));

        }
    }
}
