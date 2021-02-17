using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._songs_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();
            Queue<string> queue = new Queue<string>(input);

            while (queue.Count > 0)
            {
                List<string> command = Console.ReadLine().Split(" ").ToList();

                switch (command[0])
                {
                    case "Play":
                        queue.Dequeue();
                        break;
                    case "Add":
                        string songName = command[1];
                        for (int i = 1; i < command.Count - 1; i++)
                        {
                            songName += " " + command[i + 1];
                        }
                        if (!(queue.Contains(songName)))
                        {
                            queue.Enqueue(songName);
                        }
                        else
                        {
                            Console.WriteLine($"{songName} is already contained!");
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", queue));
                        break;
                }
            }
            if (queue.Count == 0)
            {
                Console.WriteLine("No more songs!");
            }
        }
    }
}
