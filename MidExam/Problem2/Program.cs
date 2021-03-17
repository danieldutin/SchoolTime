using System;
using System.Linq;
using System.Collections.Generic;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sugarCubes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string[] command = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (command[0]=="Mort")
                {
                    break;
                }

                MyMethod(command, sugarCubes);
            }

            Console.WriteLine(string.Join(" ", sugarCubes));
        }

        public static void MyMethod(string[] arr, List<int> myList)
        {
            int current = int.Parse(arr[1]);
            
            switch (arr[0])
            {
                case "Add":
                    myList.Add(current);
                    break;

                case "Remove":
                    myList.Remove(current);
                    break;

                case "Replace":
                    int replacement = int.Parse(arr[2]);
                    int index = myList.IndexOf(current);
                    myList[index] = replacement;
                   
                    break;

                case "Collapse":
                    myList.RemoveAll(a => a < current);
                    break;

            }
        }
    }
}
