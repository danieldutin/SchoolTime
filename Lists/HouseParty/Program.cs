using System;
using System.Collections.Generic;
using System.Linq;
namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandsCount = int.Parse(Console.ReadLine());

            List<string> guests = new List<string>(commandsCount);



            for (int i = 0; i < commandsCount; i++)
            {
                string[] newCommand = Console.ReadLine()
                    .Split()
                    .ToArray();

                string current = newCommand[0];
                string currentSecond = newCommand[1];
                string currentThird = newCommand[2];
               
                
                if (currentThird == "not")
                {
                    if (guests.Contains(current))
                    {
                        guests.Remove(current);
                        break;
                    }
                }
                if (guests.Contains(current))
                {
                    Console.WriteLine($"{current} is already in the list!");
                }
                else
                {
                    guests.Add(current);
                }
                
            }

            Console.WriteLine(string.Join(" ", guests));
        }
    }
}
