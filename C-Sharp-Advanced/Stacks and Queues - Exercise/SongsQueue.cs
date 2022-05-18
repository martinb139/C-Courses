using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Songs_Queue
{
    internal class SongsQueue
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.None));

            if (songs.Contains("Add") || songs.Contains("Show") || songs.Contains("Play"))
            {
                songs.Clear();
            }

            while (true)
            {

                string commands = Console.ReadLine();

                if (songs.Count < 0)
                {
                    break;
                }

                if (commands == "Play")
                {
                    if (songs.Count > 0)
                    {
                        songs.Dequeue();

                        if(songs.Count == 0)
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }

                }
                else if (commands.Contains("Add"))
                {
                    string song = commands.Substring(4);

                    if (songs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(song);
                    }
                }
                else if (commands == "Show")
                {
                    Console.WriteLine(String.Join(", ", songs));
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
