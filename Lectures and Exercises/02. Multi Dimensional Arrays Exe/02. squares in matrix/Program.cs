using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._squares_in_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> rowsColm = Console.ReadLine().Split(" ").Select(int.Parse).ToList();

            char[,] matrix = new char[rowsColm[0], rowsColm[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] colElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            int count = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] && matrix[row, col] == matrix[row + 1, col] && matrix[row, col] == matrix[row+1, col+1])
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
