using System;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int countLectures = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());

            double bestBonus = 0;
            int bestStudent = 0;
            for (int i = 0; i < count; i++)
            {
                int studentLectures = int.Parse(Console.ReadLine());
                double totalBonus = (double)studentLectures / (double)countLectures * (5 + initialBonus);
                if (totalBonus > bestBonus)
                {
                    bestBonus = totalBonus;
                    bestStudent = studentLectures;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(bestBonus)}.");
            Console.WriteLine($"The student has attended {bestStudent} lectures.");
        }
    }
}
