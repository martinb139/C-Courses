using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Supermarket
{
    internal class Supermarket
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Queue<string> customers = new Queue<string>();
            List<string> customersPassed = new List<string>();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    if (customers.Count > 0)
                    {
                        int count = customers.Count;

                        for (int i = 0; i < count; i++)
                        {
                            customersPassed.Add(customers.Dequeue());
                        }
                    }
                }
                else
                {
                    customers.Enqueue(input);
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < customersPassed.Count; i++)
            {
                Console.WriteLine(customersPassed[i]);
            }

            Console.WriteLine($"{customers.Count()} people remaining.");
        }
    }
}
