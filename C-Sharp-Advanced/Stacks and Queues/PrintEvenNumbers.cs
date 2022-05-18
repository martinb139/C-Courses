using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Print_Even_Numbers
{
    internal class PrintEvenNumbers
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            int count = queue.Count;
            List<int> numbers = new List<int>();

            for (int i = 0; i < count; i++)
            {
                if(queue.Peek() % 2 == 0)
                {
                    numbers.Add(queue.Dequeue());
                }
                else
                {
                    queue.Dequeue();
                }
            }

            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
