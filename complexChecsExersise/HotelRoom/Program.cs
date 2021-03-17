using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            const double mayEndOctoberStP = 50;
            const double mayEndOctoberApP = 65;
            const double juneAndSepStP = 75.20;
            const double juneAndSepApP = 68.70;
            const double julyAndAugStP = 76;
            const double julyAndAugApP = 77;

            string season = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double totalMoneyStudio = 0;
            double totalMoneyApp = 0;

            switch (season)
            {
                case "May":
                    totalMoneyStudio = nights * mayEndOctoberStP;
                    totalMoneyApp = nights * mayEndOctoberApP;

                    if (nights > 7 && nights < 14)
                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.05;
                    }
                    else if (nights > 14)
                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.30;
                    }
                    break;

                case "October":
                    totalMoneyStudio = nights * mayEndOctoberStP;
                    totalMoneyApp = nights * mayEndOctoberApP;
                    if (nights > 7 && nights < 14)
                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.05;
                    }
                    else if (nights > 14)
                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.30;
                    }
                    break;
                case "June":
                    totalMoneyStudio = nights * juneAndSepStP;
                    totalMoneyApp = nights * juneAndSepApP;
                    if (nights > 14)
                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.20;
                    }
                    break;
                case "September":
                    totalMoneyStudio = nights * juneAndSepStP;
                    totalMoneyApp = nights * juneAndSepApP;
                    if (nights > 14)
                    {
                        totalMoneyStudio -= totalMoneyStudio * 0.20;
                    }
                    break;
                case "July":
                    totalMoneyStudio = nights * julyAndAugStP;
                    totalMoneyApp = nights * julyAndAugApP;

                    break;
                case "August":
                    totalMoneyStudio = nights * julyAndAugStP;
                    totalMoneyApp = nights * julyAndAugApP;
                    break;

            }
            if (nights >14)
            {
                totalMoneyApp -= nights * 0.10;
            }
            Console.WriteLine($"Apartment: {totalMoneyApp :f2} lv.");
            Console.WriteLine($"Studio: {totalMoneyStudio :f2} lv.");
        }
    }
}
