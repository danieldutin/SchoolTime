using System;

namespace leftRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int leftsum = 0;
            int rightsum = 0;

            for (int i = 0; i < count; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                leftsum += currentNum;
            }

            for (int i = 0; i < count; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                rightsum += currentNum;
            }

            if (leftsum == rightsum)
            {
                Console.WriteLine($"Yes, sum = {leftsum}");
            }
            else
            {
                int diff = Math.Abs(leftsum - rightsum);
                Console.WriteLine($"No, diff = {diff}");
            }
        }

    }
}
