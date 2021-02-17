using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._basic_stack_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> stackInput = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < input[0]; i++)
            {
                stack.Push(stackInput[i]);
            }
            for (int i = 0; i < input[1]; i++)
            {
                stack.Pop();
            }
            if (stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                if (stack.Contains(input[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }

            }
        }
    }
}
