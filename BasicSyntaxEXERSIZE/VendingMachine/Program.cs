using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {


            double coins = 0;
            double currentCoin;
            double currentPrice = 0;
            double price = 0;
            string input = Console.ReadLine();
            bool invalid = false;

            while (input != "Start")
            {
                currentCoin = double.Parse(input);
                if (currentCoin == 0.1 || currentCoin == 0.2 || currentCoin == 0.5 || currentCoin == 1 || currentCoin == 2)
                {
                    coins += currentCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currentCoin}");
                }
                input = Console.ReadLine();
            }
            string product = Console.ReadLine().ToLower();
            while (product != "end")
            {
                switch (product)
                {
                    case "nuts":
                        currentPrice = 2;
                        break;
                    case "water":
                        currentPrice = 0.7;
                        break;
                    case "crisps":
                        currentPrice = 1.5;
                        break;
                    case "soda":
                        currentPrice = 0.8;
                        break;
                    case "coke":
                        currentPrice = 1;
                        break;
                    case "end":
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        invalid = true;
                        break;
                }
                if (invalid)
                {
                    product = Console.ReadLine().ToLower();
                    continue;
                }
                else if (price + currentPrice > coins)
                {
                    Console.WriteLine($"Sorry, not enough money");
                    currentPrice = 0;
                    product = Console.ReadLine().ToLower();
                }
                else if (product != "end")
                {
                    price += currentPrice;
                    currentPrice = 0;
                    Console.WriteLine($"Purchased {product}");
                    product = Console.ReadLine().ToLower();
                }
                else if (coins > price && product == "end")
                {
                    Console.WriteLine($"Change: {(coins - price):f2}");
                }
            }
            Console.WriteLine($"Change: {(coins - price):f2}");
        }
    }
}
