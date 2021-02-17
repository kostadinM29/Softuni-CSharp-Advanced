using System;
using System.Collections.Generic;

namespace _06._supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                if (command == "Paid")
                {
                    for (int i = queue.Count; i > 0; i--)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }
            }
                Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
