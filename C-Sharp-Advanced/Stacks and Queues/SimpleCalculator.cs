using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numsAndOperations = Console.ReadLine().Split(' ').ToArray();
            Stack<string> stack = new Stack<string>();

            foreach (var item in numsAndOperations)
            {
                stack.Push(item);
            }

            Stack<string> rev = new Stack<string>();
            while (stack.Count != 0)
            {
                rev.Push(stack.Pop());
            }

            int sum = int.Parse(rev.Pop());


            while (rev.Count > 0)
            {
                if (rev.Pop() == "+")
                {
                    sum += int.Parse(rev.Pop());
                }
                else
                {
                    sum -= int.Parse(rev.Pop());
                }
            }

            Console.WriteLine(sum);
        }
    }
}
