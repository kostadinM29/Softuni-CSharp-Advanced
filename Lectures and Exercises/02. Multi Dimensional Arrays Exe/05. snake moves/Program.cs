using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._snake_moves
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> rowsColm = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            string snakeName = Console.ReadLine();
            char[,] matrix = new char[rowsColm[0], rowsColm[1]];

            int currentLetter = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snakeName[currentLetter];
                        currentLetter++;
                        if (currentLetter == snakeName.Length)
                        {
                            currentLetter = 0;
                        }
                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = snakeName[currentLetter];
                        currentLetter++;
                        if (currentLetter == snakeName.Length)
                        {
                            currentLetter = 0;
                        }
                    }
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row,col]}");
                }
                Console.WriteLine();
            }
        }
    }
}
