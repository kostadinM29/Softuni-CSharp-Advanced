using System;
using System.Collections.Generic;
using System.Linq;

namespace garden
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[,] matrix = new int[dimensions[0], dimensions[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = 0;
                }
            }
            while (true)
            {
                string input = Console.ReadLine();
                List<string> command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (input == "Bloom Bloom Plow")
                {
                    break;
                }
                int inputRow = int.Parse(command[0]);
                int inputCol = int.Parse(command[1]);

                if ((inputRow >= matrix.GetLength(0) || inputRow < 0) || (inputCol >= matrix.GetLength(1) || inputCol < 0))
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }
                else
                {
                    /// implement out of bounds
                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            if (row == inputRow || col == inputCol)
                            {
                                matrix[row, col]++;
                            }
                        }
                    }
                }
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
