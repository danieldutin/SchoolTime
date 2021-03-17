using System;

namespace TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int count = 0;
            int allProducts = 0;
            double total = 0;
            string text = Console.ReadLine();
            while (text != "Stop")
            {
                double price = double.Parse(Console.ReadLine());
                count++;
                if (count==3)
                {
                    count = 0;
                    price = price / 2;
                }
                if (price + total > budget)
                {
                    double neededMoney = price + total - budget;
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {neededMoney:f2} leva!");
                    break;
                }
                allProducts++;
                total += price;
                text = Console.ReadLine();
            }

            if (text == "Stop")
            {
                Console.WriteLine($"You bought {allProducts} products for {total:f2} leva.");
            }
        }
    }
}
