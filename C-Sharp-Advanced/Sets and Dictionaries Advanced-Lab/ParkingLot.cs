using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class ParkingLot
{
    static void Main(string[] args)
    {
        HashSet<string> carNumbers = new HashSet<string>();

        string[] numberAndCommand = Console.ReadLine()
            .Split(new string[] { ", " }, StringSplitOptions.None).ToArray();

        while (numberAndCommand[0] != "END")
        {
            if(numberAndCommand[0] == "IN")
            {
                carNumbers.Add(numberAndCommand[1]);
            }
            else if(numberAndCommand[0] == "OUT")
            {
                carNumbers.Remove(numberAndCommand[1]);
            }

            numberAndCommand = Console.ReadLine()
            .Split(new string[] { ", " }, StringSplitOptions.None).ToArray();
        }

        if(carNumbers.Count > 0)
        {
            foreach (var carNumber in carNumbers)
            {
                Console.WriteLine(carNumber);
            }
        }
        else
        {
            Console.WriteLine("Parking Lot is Empty");
        }
    }
}
