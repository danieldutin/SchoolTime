using System;
using System.Linq;
namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

            Console.Write($"{string.Join(' ', arr.Reverse())} ");


        }
    }
}
