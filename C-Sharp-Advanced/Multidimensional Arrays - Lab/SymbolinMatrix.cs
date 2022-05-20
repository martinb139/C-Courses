using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Symbol_in_Matrix
{
    internal class SymbolinMatrix
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrixSymbols = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] input = Console.ReadLine().ToCharArray();

                for (int col = 0; col < n; col++)
                {
                    matrixSymbols[row, col] = input[col];
                }
            }

            char symbol = char.Parse(Console.ReadLine());
            bool symbolExists = false;

            for (int row = 0; row < matrixSymbols.GetLength(0); row++)
            {
                for (int col = 0; col < matrixSymbols.GetLength(1); col++)
                {
                    char currentSymbol = matrixSymbols[row, col];
                    if (currentSymbol == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        symbolExists = true;
                        break;
                    }
                }

                if (symbolExists == true)
                {
                    break;
                }
            }

            if (symbolExists == false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix");
            }
        }
    }
}
