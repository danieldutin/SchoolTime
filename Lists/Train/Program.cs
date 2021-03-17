using System;
using System.Collections.Generic;
using System.Linq;


namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int capacityOfWagon = int.Parse(Console.ReadLine());

            while (true)
            {
                string[] command = Console.ReadLine().Split().ToArray();
                if (command[0] == "end")
                {
                    break;
                }
                else if (command[0] == "Add")
                {
                    int wagon = int.Parse(command[1]);

                    train.Add(wagon);
                }
                else
                {
                    int passengers = int.Parse(command[0]);
                    for (int i = 0; i < train.Count; i++)
                    {
                        if (train[i]+passengers <= capacityOfWagon)
                        {
                            train[i] += passengers;
                            break;
                        }
                    }
                   
                }
            }

            Console.WriteLine(string.Join(" ", train));
        }
    }
}
