using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._biggest_2x2_square
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> rowsColm = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            int[,] matrix = new int[rowsColm[0], rowsColm[1]];

            int maxSum = int.MinValue;
            int maxRow = 0;
            int maxCol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int sum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];
                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }
            Console.WriteLine(matrix[maxRow, maxCol] + " " + matrix[maxRow, maxCol + 1]);
            Console.WriteLine(matrix[maxRow+1, maxCol] + " " + matrix[maxRow+1, maxCol + 1]);
            Console.WriteLine(maxSum);
        }
    }
}
