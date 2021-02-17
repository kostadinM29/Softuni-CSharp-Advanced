using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._max_and_min_element
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<string> command = Console.ReadLine().Split(" ").ToList();
                switch (command[0])
                {
                    case "1":
                        int element = int.Parse(command[1]);
                        stack.Push(element);
                        break;
                    case "2":
                        stack.Pop();
                        break;
                    case "3":
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Max());
                        }
                        break;
                    case "4":
                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Min());
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}
