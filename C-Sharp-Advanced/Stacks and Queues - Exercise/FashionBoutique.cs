using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fashion_Boutique
{
    internal class FashionBoutique
    {
        static void Main(string[] args)
        {
            Stack<int> clothesBox = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            int rackCapacity = int.Parse(Console.ReadLine());
            int rackCounter = 1;
            int clothesCount = clothesBox.Count();
            int rackSpace = 0;

            for (int i = 0; i < clothesCount; i++)
            {
                if(rackSpace + clothesBox.Peek() <= rackCapacity)
                {
                    rackSpace += clothesBox.Pop();
                }
                else
                {
                    rackSpace = 0;
                    rackSpace += clothesBox.Pop();
                    rackCounter++;
                }


            }

            Console.WriteLine(rackCounter);
            
        }
    }
}
