using System;

namespace fishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            const int springPrice = 3000;
            const int summerAndAutumn = 4200;
            const int winter = 2600;
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermans = int.Parse(Console.ReadLine());

            double totalPrice = 0;
            double moneyLeft = 0;

            switch (season)
            {
                case "Spring":
                    totalPrice = springPrice;

                    break;

                case "Summer":
                    totalPrice = summerAndAutumn;
                    break;

                case "Autumn":
                    totalPrice = summerAndAutumn;
                    break;

                case "Winter":
                    totalPrice = winter;
                    break;

            }
            if (fishermans <= 6)
            {
                totalPrice -= totalPrice * 0.10;
            }
            else if (fishermans <= 11)
            {
                totalPrice -= totalPrice * 0.15;
            }
            else
            {
                totalPrice -= totalPrice * 0.25;
            }

            if (season != "Autumn" && fishermans % 2 == 0)
            {
                totalPrice -= totalPrice * 0.05;
            }

            if (budget >= totalPrice)
            {
                moneyLeft = budget - totalPrice;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");

            }
            else if (budget < totalPrice)
            {
                moneyLeft = totalPrice - budget;
                Console.WriteLine($"Not enough money! You need {moneyLeft:f2} leva.");
            }


        }
    }
}
