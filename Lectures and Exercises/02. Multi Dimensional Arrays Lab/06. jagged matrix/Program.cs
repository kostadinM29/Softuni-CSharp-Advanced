using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._jagged_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> rowsColm = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            int[,] matrix = new int[rowsColm[0], rowsColm[0]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            while (true)
            {
                List<string> command = Console.ReadLine().Split(" ").ToList();
                if (command[0] == "END")
                {
                    break;
                }
                if (command[0] == "Add")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);
                    if (row > matrix.GetLength(0)-1 || col > matrix.GetLength(1)-1 || row < 0 || col < 0)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        matrix[row, col] += value;
                    }
                }
                else if (command[0] == "Subtract")
                {
                    int row = int.Parse(command[1]);
                    int col = int.Parse(command[2]);
                    int value = int.Parse(command[3]);
                    if (row > matrix.GetLength(0)-1 || col > matrix.GetLength(1)-1 || row < 0 || col < 0)
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                    else
                    {
                        matrix[row, col] -= value;
                    }
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
