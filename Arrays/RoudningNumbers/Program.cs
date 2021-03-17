using System;
using System.Linq;

namespace RoudningNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(float.Parse)
                .ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{array[i]} => {Math.Round(array[i], MidpointRounding.AwayFromZero)}");
            }

        }
    }
}
