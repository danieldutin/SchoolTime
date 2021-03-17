using System;
using System.Collections.Generic;
using System.Linq;
namespace ChangeList
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
                string[] command = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (command[0] == "end")
                {
                    break;
                }
                else if (command[0] == "Delete")
                {
                    int parsing = int.Parse(command[1]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] == parsing)
                        {
                            numbers.RemoveAll(x => x == parsing);
                        }
                    }
                }
                else
                {
                    int element = int.Parse(command[1]);
                    int index = int.Parse(command[2]);

                    numbers.Insert(index, element);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
