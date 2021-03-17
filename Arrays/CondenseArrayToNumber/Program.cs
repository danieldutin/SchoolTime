using System;
using System.Linq;
namespace CondenseArrayToNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] condensed = new int[arr.Length-1];

            //int sum = 0;
            //int sumNext = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr.Length<1)
                {
                    Console.WriteLine($"{arr[i]} is already condensed to number");
                }
            }
        }
    }
}
