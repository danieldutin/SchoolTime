using System;

namespace PoundToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double converter = double.Parse(Console.ReadLine())*1.31;
            Console.WriteLine($"{converter:f3}");
        }
    }
}
