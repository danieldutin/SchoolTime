﻿using System;

namespace NextOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var sum = 0;
            for (int i = 1; i <= n*2; i+=2)
            {
                if (i%2!=0)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
