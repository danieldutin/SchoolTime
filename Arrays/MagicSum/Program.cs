﻿using System;
using System.Linq;
namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int number = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < array.Length; i++)
            {
                

                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == number)
                    {
                        Console.Write($"{array[i]} {array[j]}");
                    }
                    
                }

                Console.WriteLine();

            }
        }
    }
}
