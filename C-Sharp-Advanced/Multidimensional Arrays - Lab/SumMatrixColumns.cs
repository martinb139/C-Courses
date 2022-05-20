using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Sum_Matrix_Columns
{
    internal class SumMatrixColumns
    {
        static void Main(string[] args)
        {
            string[] rowsAndCols = Console.ReadLine().Trim().Split(',').ToArray();
            int rows = int.Parse(rowsAndCols[0]);
            int cols = int.Parse(rowsAndCols[1]);
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            int[] sum = new int[cols];

            for (int matrixColSum = 0; matrixColSum < matrix.GetLength(1); matrixColSum++)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum[matrixColSum] += matrix[row, matrixColSum];
                }
            }

            foreach (int col in sum)
            {
                Console.WriteLine(col);
            }
        }
    }
}
