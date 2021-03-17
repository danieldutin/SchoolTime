using System;

namespace godzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double clothesStatists = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double priceForClothes = statists * clothesStatists;

            if (statists > 150)
            {
                double discount = priceForClothes * 0.10;
                priceForClothes -= discount;
            }
            double tottalMoney = decor + priceForClothes;
            if (tottalMoney <= budget)
            {
                double moneyLeft = budget - tottalMoney;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = tottalMoney - budget;
                Console.WriteLine("Not enought money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:f2} more.");
            }
        }
    }
}
