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
                string[] input = Console.ReadLine().Split();
                if (input[0] == "End")
                {
                    break;
                }


                if (input[0] == "Add")
                {
                    numbers.Add(int.Parse(input[1]));
                }
                else if (input[0] == "Remove")
                {
                    int command = int.Parse(input[1]);
                    if (command < 0 || command >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.RemoveAt(int.Parse(input[1]));
                }
                else if (input[0] == "Insert")
                {


                    int command = int.Parse(input[1]);
                    int idx = int.Parse(input[2]);

                    if(command < 0 || command >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(idx, command);
                }
                else if (input[0] == "Shift")
                {

                    string direction = input[1];
                    int count = int.Parse(input[2]);
                    

                        if (direction == "left")
                        {
                            for (int i = 0; i < count; i++)
                            {
                                int firstElement = numbers[0];
                                numbers.RemoveAt(0);
                                numbers.Add(firstElement);
                            }
                        }
                        else
                        {

                            for (int i = 0; i < count; i++)
                            {
                                int lastElement = numbers[numbers.Count - 1];
                                numbers.RemoveAt(numbers[numbers.Count - 1]);
                                numbers.Insert(0, lastElement);
                            }
                        }
                    
                    

                }

                
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
