using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Cities_by_Continent_and_Country
{
    internal class CitiesByContinentAndCountry
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> map =
                new Dictionary<string, Dictionary<string, List<string>>>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] mapReader = Console.ReadLine().Split(' ').ToArray();

                if (!map.ContainsKey(mapReader[0]))
                {
                    map.Add(mapReader[0], new Dictionary<string, List<string>>());
                    map[mapReader[0]].Add(mapReader[1], new List<string>() { mapReader[2] });
                }
                else
                {
                    if (map[mapReader[0]].ContainsKey(mapReader[1]))
                    {
                        map[mapReader[0]][mapReader[1]].Add(mapReader[2]);
                    }
                    else
                    {
                        map[mapReader[0]].Add(mapReader[1], new List<string> { mapReader[2] });
                    }
                }
            }

            foreach (var continent in map.Keys)
            {
                Console.WriteLine($"{continent}:");
                foreach (var country in map[continent])
                {
                    Console.WriteLine($"{country.Key} -> {String.Join(", ", country.Value)}");
                }
            }
        }
    }
}
