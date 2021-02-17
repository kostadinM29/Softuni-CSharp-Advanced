using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._symbol_matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> rowsColm = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

            string[,] matrix = new string[rowsColm[0], rowsColm[0]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] colElements = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col].ToString();
                }
            }
            string symbol = Console.ReadLine();
            bool isFound = false;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col].ToString() == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        isFound = true;
                        break;
                    }
                    if (isFound)
                    {
                        break;
                    }
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
