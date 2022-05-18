using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Traffic_Jam
{
    internal class TrafficJam
    {
        static void Main(string[] args)
        {
            int carPassCount = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string carToPass = Console.ReadLine();
            int count = 0;

            while (carToPass != "end")
            {
                if (carToPass == "green")
                {
                    for (int i = 0; i < carPassCount; i++)
                    {
                        if (cars.Count > 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            count++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(carToPass);
                }

                carToPass = Console.ReadLine();
            }

            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
