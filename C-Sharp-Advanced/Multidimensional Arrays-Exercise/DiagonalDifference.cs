using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Diagonal_Difference
{
    internal class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;
            int totalSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < input.Length; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                primaryDiagonalSum += matrix[row, row];
            }

            for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
            {
                secondaryDiagonalSum += matrix[matrix.GetLength(0) - col - 1, col];
            }

            totalSum = primaryDiagonalSum - secondaryDiagonalSum;

            Console.WriteLine(Math.Abs(totalSum));
        }
    }
}
