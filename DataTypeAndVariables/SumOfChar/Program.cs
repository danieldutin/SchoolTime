using System;
using System.Collections.Generic;

namespace SumOfChar
{
    class Program
    {
        static void Main(string[] args)
        {
            int interval = int.Parse(Console.ReadLine());
            long sum = 0;

            for (int i = 0; i < interval; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                sum += letter; // if we try to do math operations between int and char we can tread char as int and the value will be the ascii representation;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }

    }
}
