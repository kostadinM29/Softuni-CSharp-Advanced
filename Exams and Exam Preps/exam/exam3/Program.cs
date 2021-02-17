using System;
using System.Collections.Generic;
using System.Linq;

namespace exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();
            while (true)
            {
                List<string> command = Console.ReadLine().Split(" - ").ToList();
                if (command[0] == "Craft!")
                {
                    break;
                }
                switch (command[0])
                {
                    case "Collect":
                        if (!items.Contains(command[1]))
                        {
                            items.Add(command[1]);
                        }
                        break;
                    case "Drop":
                        if (items.Contains(command[1]))
                        {
                            items.Remove(command[1]);
                        }
                        break;
                    case "Combine Items":
                        List<string> combine = command[1].Split(':').ToList();
                        if (items.Contains(combine[0]))
                        {
                            int oldItemIndex = items.IndexOf(combine[0]);
                            items.Insert(oldItemIndex + 1, combine[1]);
                        }
                        break;
                    case "Renew":
                        if (items.Contains(command[1]))
                        {
                            items.Remove(command[1]);
                            items.Add(command[1]);
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", items));
        }
    }
}
