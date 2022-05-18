using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Maximum_and_Minimum_Element
{
    internal class MaximumAndMinimumElement
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] commandsAndElements = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (commandsAndElements[0] == 1)
                {
                    stack.Push(commandsAndElements[1]);
                }
                else if (commandsAndElements[0] == 2)
                {
                    if (stack.Count > 0)
                    {
                        stack.Pop();
                    }
                }
                else if (commandsAndElements[0] == 3)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (commandsAndElements[0] == 4)
                {
                    if (stack.Count > 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }

            Console.WriteLine(String.Join(", ", stack));
        }
    }
}
