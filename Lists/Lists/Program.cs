using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                numbers.Add(i);
            }
            //numbers.Clear();
            
            //Console.WriteLine($"Capacity:{numbers.Capacity}, count:{numbers.Count} ");
            //foreach (int item in numbers)
            //{
            //    Console.Write($"{numbers[item]} ");
            //}

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
