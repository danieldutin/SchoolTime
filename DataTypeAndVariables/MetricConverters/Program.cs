﻿using System;

namespace MetricConverters
{
    class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            decimal kilometers = meters / 1000m;
            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
