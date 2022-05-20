using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Square_With_Maximum_Sum
{
    internal class SquareWithMaximumSum
    {
        static void Main(string[] args)
        {
            int[] rowsAndColsCount = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None)
                .Select(int.Parse).ToArray();
            int[,] matrix = new int[rowsAndColsCount[0], rowsAndColsCount[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] inputNumbers = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None)
                    .Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputNumbers[col];
                }
            }

            int sum = default;
            int actualSum = int.MinValue;
            int firstNumber = default;
            int secondNumber = default;
            int thirdNumber = default;
            int fourthNumber = default;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    sum += matrix[row, col];
                    sum += matrix[row, col + 1];
                    sum += matrix[row + 1, col];
                    sum += matrix[row + 1, col + 1];

                    if(sum > actualSum)
                    {
                        actualSum = sum;
                        firstNumber = matrix[row, col];
                        secondNumber = matrix[row, col + 1];
                        thirdNumber = matrix[row + 1, col];
                        fourthNumber = matrix[row + 1, col + 1];
                    }

                    sum = 0;
                }
            }

            Console.WriteLine($"{firstNumber} {secondNumber}");
            Console.WriteLine($"{thirdNumber} {fourthNumber}");
            Console.WriteLine($"{actualSum}");
        }
    }
}
