using System;
using System.Linq;
namespace CommonElemets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string[] second = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            for (int i = 0; i < second.Length; i++)
            {
                for (int j = 0; j < first.Length; j++)
                {
                    if (second[i] == first[j])
                    {
                        Console.Write($"{second[i]} ");
                    }
                }
            }
        }
    }
}
