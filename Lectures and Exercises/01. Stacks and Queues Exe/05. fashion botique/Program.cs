using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._fashion_botique
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> clothes = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            Stack<int> stack = new Stack<int>();
            for (int i = 0; i < clothes.Count; i++)
            {
                stack.Push(clothes[i]);
            }
            int capacity = int.Parse(Console.ReadLine());
            int limit = 0;
            int racks = 0;

            for (int i = 0; i < clothes.Count; i++)
            {
                if (limit + stack.Peek() == capacity)
                {
                    limit = 0;
                    racks++;
                    stack.Pop();
                }
                else if (limit + stack.Peek() > capacity)
                {
                    limit = stack.Pop();
                    racks++;
                }
                else if (limit + stack.Peek() < capacity)
                {
                    limit += stack.Pop();
                }
            }
            if (limit> 0)
            {
                racks++;
            }
            Console.WriteLine(racks);
        }
    }
}
