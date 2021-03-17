using System;
using System.Linq;

namespace Largest3numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();
            int[] sorted = numbers.OrderByDescending(n => n).ToArray();

            for (int i = 0; i < 2; i++)
            {
                Console.Write($"{sorted[i]} ");
            }
        }
    }
}
