using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._stacksum
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            string[] input = Console.ReadLine().Split(' ').ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                stack.Push(int.Parse(input[i]));
            }

            while (true)
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();
                if (command[0].ToLower() == "end")
                {
                    break;
                }
                switch (command[0].ToLower())
                {
                    case "add":
                        stack.Push(int.Parse(command[1]));
                        stack.Push(int.Parse(command[2]));
                        break;
                    case "remove":
                        int numsToRemove = int.Parse(command[1]);
                        if (numsToRemove <= stack.Count)
                        {
                            for (int i = 0; i < numsToRemove; i++)
                            {
                                stack.Pop();
                            }
                        }
                        break;

                }
            }
            Console.WriteLine("Sum: "+ stack.Sum());
        }
    }
}
