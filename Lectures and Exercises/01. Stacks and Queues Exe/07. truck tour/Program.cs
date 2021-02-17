using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._truck_tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumps = int.Parse(Console.ReadLine());
            Queue<string> queue = new Queue<string>();

            for (int i = 0; i < pumps; i++)
            {
                string input = Console.ReadLine();
                input += $" {i}";
                queue.Enqueue(input);
            }

            int totalFuel = 0;

            for (int i = 0; i < pumps; i++)
            {
                string currentInfo = queue.Dequeue();
                List<int> info = currentInfo.Split(' ').Select(int.Parse).ToList();

                int fuel = info[0];
                int distance = info[1];
                totalFuel += fuel;
                if (totalFuel >= distance)
                {
                    totalFuel -= distance;
                }
                else
                {
                    totalFuel = 0;
                    i = -1;
                }
                queue.Enqueue(currentInfo);
            }
            List<int> finalInfo = queue.Dequeue().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine(finalInfo[2]);
        }
    }
}
