using System;
using System.Collections.Generic;

namespace _08._traffic_jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();
            int counter = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                if (command == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count == 0)
                        {
                            break;
                        }
                        Console.WriteLine($"{queue.Dequeue()} passed!");
                        counter++;
                    }
                }
                else
                {
                    queue.Enqueue(command);
                }

            }
            Console.WriteLine($"{counter} cars passed the crossroads.");

        }
    }
}
