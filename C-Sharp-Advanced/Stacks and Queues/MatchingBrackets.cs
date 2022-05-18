using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> bracketIndex = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (ch == '(')
                {
                    bracketIndex.Push(i);
                }
                else if (ch == ')')
                {
                    int startIndex = bracketIndex.Pop();
                    string substring = input.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(substring);
                }
            }
        }
    }
}
