using System;

namespace sumEqualsElementInside
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            
            for (int i = 0; i < input; i++)
            {
                int current = int.Parse(Console.ReadLine());
                sum += current;
                if (current > max)
                {
                    max = current;
                }
            }
            int sumWithoutMax = sum - max;
            if (max == sumWithoutMax)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + max);
            }
            else
            {
                int diff = Math.Abs(max - sumWithoutMax);
                Console.WriteLine("No");
                Console.WriteLine("Diff = " + diff);
            }
        }
    }
}
