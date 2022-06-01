using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Same_Values_in_Array
{
    internal class CountSameValuesinArray
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            Dictionary<double, int> count = new Dictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if(count.ContainsKey(numbers[i]))
                {
                    count[numbers[i]]++;
                }
                else
                {
                    count.Add(numbers[i], 1);
                }
            }

            foreach (var number in count)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
        }
    }
}
