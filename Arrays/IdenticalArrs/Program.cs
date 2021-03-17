using System;
using System.Linq;

namespace IdenticalArrs
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] first = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] second = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sum = 0;
            int firstDiference = 0;
            bool identical = true;

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                {
                    firstDiference = i;
                    identical = false;
                    break;
                }

                sum += first[i];
            }

            if (identical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {firstDiference} index");
            }
        }
    }
}
