using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "Add")
                {
                    int addN = int.Parse(command[1]);
                    numbers.Add(addN);
                }
                else if (command[0] == "Remove")
                {
                    int remN = int.Parse(command[1]);
                    numbers.Remove(remN);
                }
                else if (command[0] == "RemoveAt")
                {
                    int remAtN = int.Parse(command[1]);

                    numbers.RemoveAt(remAtN);
                    
                }
                else if (command[0] == "Insert")
                {
                    int rangeA = int.Parse(command[1]);
                    int rangeB = int.Parse(command[2]);

                    numbers.Insert(rangeB, rangeA);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));

        }


    }
}


