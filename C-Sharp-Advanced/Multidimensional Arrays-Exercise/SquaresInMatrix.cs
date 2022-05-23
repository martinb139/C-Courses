using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Squares_in_Matrix
{
    internal class SquaresInMatrix
    {
        static void Main(string[] args)
        {
            int[] rowsAndCols = Console.ReadLine().Split(' ').Select(int.Parse).Where(x => !x.Equals(' ')).ToArray();
            char[,] matrix = new char[rowsAndCols[0], rowsAndCols[1]];
            int counter = 0;

            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                char[] input = Console.ReadLine().Split().Select(char.Parse).Where(x => !x.Equals(' ')).ToArray();
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    matrix[rows, cols] = input[cols];
                }
            }

            for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1) - 1; cols++)
                {
                    if (matrix[rows, cols] == matrix[rows, cols + 1]
                        && matrix[rows, cols] == matrix[rows + 1, cols]
                        && matrix[rows, cols] == matrix[rows + 1, cols + 1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
