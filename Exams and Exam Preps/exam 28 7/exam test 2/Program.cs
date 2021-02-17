using System;
using System.Collections.Generic;
using System.Linq;

namespace exam_test_2
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

            bool outOfBounds = false;
            int food = 0;
            while (true)
            {
                if (outOfBounds || food >= 10)
                {
                    break;
                }
                string command = Console.ReadLine();
                switch (command)
                {
                    case "up":
                        for (int row = 0; row < matrix.GetLength(0); row++)
                        {
                            for (int col = 0; col < matrix.GetLength(1); col++)
                            {
                                if (matrix[row,col] == "S")
                                {
                                    matrix[row, col] = "-";
                                    matrix[row, col - 1] = "S";
                                }
                            }
                        }
                        break;
                    case "down":

                        break;
                    case "left":

                        break;
                    case "right":

                        break;
                }
            }


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
