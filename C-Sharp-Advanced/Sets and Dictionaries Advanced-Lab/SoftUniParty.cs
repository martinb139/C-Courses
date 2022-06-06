using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class SoftUniParty
{
    static void Main(string[] args)
    {
        HashSet<string> regularGuest = new HashSet<string>();
        HashSet<string> vipGuest = new HashSet<string>();

        string command = Console.ReadLine();

        while(command != "PARTY")
        {
            if(command.Length == 8)
            {
                char digit = command[0];
                if(char.IsDigit(digit))
                {
                    vipGuest.Add(command);
                }
                else
                {
                    regularGuest.Add(command);
                }
            }
            command = Console.ReadLine();
        }

        while(command != "END")
        {
            command = Console.ReadLine();

            if(vipGuest.Contains(command))
            {
                vipGuest.Remove(command);
            }
            else if(regularGuest.Contains(command))
            {
                regularGuest.Remove(command);
            }
        }

        int count = vipGuest.Count + regularGuest.Count;
        Console.WriteLine(count);

        foreach (var vipNumber in vipGuest)
        {
            Console.WriteLine(vipNumber);
        }

        foreach (var regularNumber in regularGuest)
        {
            Console.WriteLine(regularNumber);
        }

    }
}
