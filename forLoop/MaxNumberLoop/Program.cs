using System;

namespace MaxNumberLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int biggest = int.MinValue;
            int smallest = int.MaxValue;

            for (int i = 0; i < number; i++)
            {
                int current = int.Parse(Console.ReadLine());
                if (current > biggest)
                {
                    biggest = current;
                }
                if (current < smallest)
                {
                    smallest = current;
                }
            }
            Console.WriteLine($"Max number: {biggest}");
            Console.WriteLine($"Min number: {smallest}");
        }

    }
}
