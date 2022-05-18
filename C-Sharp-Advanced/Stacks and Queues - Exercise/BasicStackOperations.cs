using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Basic_Stack_Operations
{
    internal class BasicStackOperations
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = nums[0];
            int s = nums[1];
            int x = nums[2];
            int[] integers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < n; i++)
            {
                stack.Push(integers[i]);
            }

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }
    }
}
