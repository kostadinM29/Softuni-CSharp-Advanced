using System;
using System.Collections.Generic;
using System.Linq;

namespace exam_test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> effects = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            List<int> casings = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            int datura = 0;
            int cherry = 0;
            int smoke = 0;
            bool pouchDone = false;
            while (effects.Count >= 1 && casings.Count >= 1)
            {
                if (smoke >= 3&& cherry >= 3 && datura >=3)
                {
                    pouchDone = true;
                    break;
                }
                int sum = effects[0] + casings[casings.Count - 1];
                switch (sum)
                {
                    case 40:
                        datura++;
                        effects.RemoveAt(0);
                        casings.RemoveAt(casings.Count - 1);
                        break;
                    case 60:
                        cherry++;
                        effects.RemoveAt(0);
                        casings.RemoveAt(casings.Count - 1);
                        break;
                    case 120:
                        smoke++;
                        effects.RemoveAt(0);
                        casings.RemoveAt(casings.Count - 1);
                        break;
                    default:
                        casings[casings.Count - 1] -= 5;
                        break;

                }
            }
            if (pouchDone)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }
            if (effects.Count > 0)
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", effects)}");
            }
            else
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            if (casings.Count > 0)
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", casings)}");
            }
            else
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            Console.WriteLine($"Cherry Bombs: {cherry}");
            Console.WriteLine($"Datura Bombs: {datura}");
            Console.WriteLine($"Smoke Decoy Bombs: {smoke}");
        }
    }
}
