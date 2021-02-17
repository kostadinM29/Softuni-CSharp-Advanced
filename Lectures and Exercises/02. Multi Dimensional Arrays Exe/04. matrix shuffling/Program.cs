using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._matrix_shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> rowsColm = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            string[,] matrix = new string[rowsColm[0], rowsColm[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] colElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            bool isInvalid = false;
            while (true)
            {
                List<string> command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (command[0] == "END")
                {
                    break;
                }
                if (command[0] == "swap" && command.Count == 5 &&
                        int.Parse(command[1]) <= rowsColm[0] &&
                        int.Parse(command[2]) <= rowsColm[1] &&
                        int.Parse(command[3]) <= rowsColm[0] &&
                        int.Parse(command[4]) <= rowsColm[1])
                {
                    string swapOne = matrix[int.Parse(command[1]), int.Parse(command[2])];
                    string swapTwo = matrix[int.Parse(command[3]), int.Parse(command[4])];
                    matrix[int.Parse(command[3]), int.Parse(command[4])] = swapOne;
                    matrix[int.Parse(command[1]), int.Parse(command[2])] = swapTwo;
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write($"{matrix[row, col]} ");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
    }
}
