using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Hot_Potato
{
    internal class HotPotato
    {
        static void Main(string[] args)
        {
            Queue<string> kids = new Queue<string>(Console.ReadLine().Split());
            int potatoCounter = int.Parse(Console.ReadLine());

            while (kids.Count > 1)
            {
                for (int i = 1; i < potatoCounter; i++)
                {
                    kids.Enqueue(kids.Dequeue());
                }

                Console.WriteLine($"Removed {kids.Dequeue()}");

            }

            Console.WriteLine($"Last is {kids.Dequeue()}");

        }
    }
}
