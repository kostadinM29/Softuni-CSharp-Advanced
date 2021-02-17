using System;
using System.Linq;

namespace _03._primary_digonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsColm = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rowsColm, rowsColm];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row==col)
                    {
                        sum += matrix[row, col];
                    }
                }
            }
            Console.WriteLine(sum);
        }
    }
}
