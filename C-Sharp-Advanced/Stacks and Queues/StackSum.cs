using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Stack_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            Stack<int> stackNumber = new Stack<int>();

            foreach (int number in numbers)
            {
                stackNumber.Push(number);
            }

            string[] commands = Console.ReadLine().ToLower().Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);

            while (commands[0] != "end")
            {
                if (commands[0] == "add")
                {
                    int num1 = int.Parse(commands[1]);
                    int num2 = int.Parse(commands[2]);

                    stackNumber.Push(num1);
                    stackNumber.Push(num2);
                }
                else if (commands[0] == "remove")
                {
                    int count = int.Parse(commands[1]);

                    if (count <= stackNumber.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stackNumber.Pop();
                        }
                    }
                }
                commands = Console.ReadLine().ToLower().Split(' ', (char)StringSplitOptions.RemoveEmptyEntries);
            }

            int sum = default;

            foreach (var item in stackNumber)
            {
                sum += item;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
