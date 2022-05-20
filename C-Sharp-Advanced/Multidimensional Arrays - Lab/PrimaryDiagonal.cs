using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Primary_Diagonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            int primaryDiagonal = default;

            for (int i = 0; i < n; i++)
            {
                
                    primaryDiagonal += matrix[i, i];
            }

            Console.WriteLine(primaryDiagonal);
        }
    }
}
