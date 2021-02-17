using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._diagonal_difference
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
            int primary = 0;
            int secondary = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == col)
                    {
                        primary += matrix[row, col];
                    }
                    if (col == matrix.GetLength(1) - 1 - row)
                    {
                        secondary += matrix[row, col];
                    }
                }
            }
           
            int sum = primary - secondary;
            Console.WriteLine(Math.Abs(sum));

        }
    }
}
