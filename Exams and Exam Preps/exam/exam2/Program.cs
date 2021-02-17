using System;
using System.Collections.Generic;
using System.Linq;

namespace exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;
            bool isPlayerDead = false;
            List<string> rooms = Console.ReadLine().Split('|').ToList();
            for (int i = 0; i < rooms.Count; i++)
            {
                if (isPlayerDead)
                {
                    break;
                }
                List<string> room = rooms[i].Split().ToList();
                switch (room[0])
                {
                    case "potion":
                        int tempHealth = health;
                        int currHealth = health;
                        currHealth += int.Parse(room[1]);
                        if (currHealth <= 100)
                        {
                            health += int.Parse(room[1]);
                            Console.WriteLine($"You healed for {room[1]} hp.");
                        }
                        if (currHealth > 100)
                        {
                            int difference = 100 - tempHealth;
                            health = 100;
                            Console.WriteLine($"You healed for {difference} hp.");
                        }
                        Console.WriteLine($"Current health: {health} hp.");
                        break;
                    case "chest":
                        bitcoins += int.Parse(room[1]);
                        Console.WriteLine($"You found {room[1]} bitcoins.");
                        break;
                    default:
                        health -= int.Parse(room[1]);
                        if (health > 0)
                        {
                            Console.WriteLine($"You slayed {room[0]}.");
                        }
                        else
                        {
                            Console.WriteLine($"You died! Killed by {room[0]}.");
                            Console.WriteLine($"Best room: {i + 1}");
                            isPlayerDead = true;
                        }
                        break;
                }
            }
            if (!isPlayerDead)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }
        }
    }
}
