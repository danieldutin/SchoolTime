using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> capsule = numbers.ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "Contains")
                {
                    int n = int.Parse(command[1]);
                    if (numbers.Contains(n))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }

                }
                else if (command[0] == "PrintEven")
                {

                    foreach (var item in numbers)
                    {
                        if (item % 2 == 0)
                        {
                            Console.Write($"{item} ");
                        }
                        
                    };
                    Console.WriteLine();
                }
                else if (command[0] == "PrintOdd")
                {
                    foreach (var item in numbers)
                    {
                        if (item % 2 != 0)
                        {
                            Console.Write($"{item} ");
                        }
                        
                    }
                    Console.WriteLine();

                }
                else if (command[0] == "GetSum")
                {
                    Console.WriteLine(GetSum(numbers));
                }
                else if (command[0] == "Filter")
                {
                    int a = int.Parse(command[2]);
                    if (command[1] == "<")
                    {
                        foreach (var item in numbers)
                        {
                            if (item<a)
                            {
                                Console.Write($"{item} ");
                            }
                        }
                        Console.WriteLine();
                        
                    }
                    else if (command[1] == ">")
                    {
                        foreach (var item in numbers)
                        {
                            if (item>a)
                            {
                                Console.Write($"{item} ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else if (command[1] == ">=")
                    {
                        foreach (var item in numbers)
                        {
                            if (item >= a)
                            {
                                Console.Write($"{item} ");
                            }
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        foreach (var item in numbers)
                        {
                            if (item <= a)
                            {
                                Console.Write($"{item} ");
                            }

                        }
                        Console.WriteLine();
                    }
                }
                else if (command[0] == "Add")
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

            if (numbers.Count != capsule.Count)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }

        static int GetSum(List<int> a)
        {
            int sum = 0;
            foreach (var item in a)
            {
                sum += item;
            }

            return sum;
        }
    }
}
