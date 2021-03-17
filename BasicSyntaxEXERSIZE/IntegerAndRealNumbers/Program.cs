using System;

namespace IntegerAndRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double kilometers = double.Parse(Console.ReadLine())/ 1000;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
