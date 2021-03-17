using System;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodBought = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double foodConsumed = 0;
            double food = foodBought * 1000;
           
            while (command != "Adopted")
            {
              
                foodConsumed += (double.Parse(command));
                food -= foodConsumed;
                if (foodBought <= 0)
                {
                    break;
                }
                
                foodConsumed = 0;
                command = Console.ReadLine();
            }
           
            if (food<0)
            {
                double foodNeeded = Math.Abs(food);
                Console.WriteLine($"Food is not enough. You need {foodNeeded} grams more.");
            }
            else
            {
                Console.WriteLine($"Food is enough! Leftovers: {food} grams.");
            }
        }
    }
}
