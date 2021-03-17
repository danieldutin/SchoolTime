using System;
using System.Collections.Generic;
using System.Linq;
namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        
        {
            List<double> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();

            int oldCount = numbers.Count;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == numbers[i+1])    // checking if the current item is equal to the next
                {
                    numbers[i] += numbers[i + 1]; // if true -> current will become equal to current + next;
                    numbers.RemoveAt(i + 1); // then will remove the next item and set the index to previous.
                    i = -1;
                    oldCount--;

                }
                
            }

            Console.WriteLine(string.Join(" ", numbers));


        }
    }
}
