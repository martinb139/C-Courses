using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Sum_Matrix_Elements
{
    internal class SumMatrixElements
    {
        static void Main(string[] args)
        {
            int[] rowsAndcols = Console.ReadLine().Trim(' ').Split(',').Select(int.Parse).ToArray();
            int[,] matrix = new int[rowsAndcols[0], rowsAndcols[1]];

            for (int rows = 0; rows <matrix.GetLength(0); rows++)
            {
                int[] colElements = Console.ReadLine().Trim(' ').Split(',').Select(int.Parse).ToArray();

                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = colElements[cols];
                }
            }

            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(sum);
        }
    }
}
