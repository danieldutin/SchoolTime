using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int cats = int.Parse(Console.ReadLine());
            double totalFoodPrice = 0;
            double totalFoodConsumed = 0;
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            for (int i = 1; i <= cats; i++)
            {
                double food = double.Parse(Console.ReadLine());
                if (food >= 100 && food < 200)
                {
                    group1++;
                }
                else if (food >= 200 && food < 300)
                {
                    group2++;
                }
                else
                {
                    group3++;
                }
                totalFoodConsumed += food;
            }
            totalFoodPrice += (totalFoodConsumed/1000) * 12.45;
            Console.WriteLine($"Group 1: {group1} cats.");
            Console.WriteLine($"Group 2: {group2} cats.");
            Console.WriteLine($"Group 3: {group3} cats.");
            Console.WriteLine($"Price for food per day: {totalFoodPrice:f2} lv.");

        }
    }
}
