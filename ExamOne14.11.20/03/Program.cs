using System;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string souvenirs = Console.ReadLine();
            int countOfBoughtS = int.Parse(Console.ReadLine());
            double flags = 0;
            double caps = 0;
            double posters = 0;
            double stickers = 0;
            double totalSpend = 0;

            if (team != "Argentina" && team !="Brazil" && team != "Croatia" && team != "Denmark")
            {
                Console.WriteLine("Invalid country!");
            }
            else if (souvenirs != "flags" && souvenirs != "caps" && souvenirs != "posters" && souvenirs != "stickers")
            {
                Console.WriteLine("Invalid stock!");
            }
            else
            {

            
            if (team == "Argentina")
            {
                switch (souvenirs)
                {
                    case "flags":
                        flags += 3.25;
                        totalSpend = flags * countOfBoughtS;
                        break;

                    case "caps":
                        caps += 7.20;
                        totalSpend = caps * countOfBoughtS;
                        break;

                    case "posters":
                        posters += 5.10;
                        totalSpend = posters * countOfBoughtS;
                        break;

                    case "stickers":
                        stickers += 1.25;
                        totalSpend = stickers * countOfBoughtS;
                        break;
                }
            }
            else if (team == "Brazil")
            {
                switch (souvenirs)
                {
                    case "flags":
                        flags += 4.20;
                        totalSpend = flags * countOfBoughtS;
                        break;

                    case "caps":
                        caps += 8.50;
                        totalSpend = caps * countOfBoughtS;
                        break;

                    case "posters":
                        posters += 5.35;
                        totalSpend = posters * countOfBoughtS;
                        break;

                    case "stickers":
                        stickers += 1.20;
                        totalSpend = stickers * countOfBoughtS;
                        break;
                }
            }
            else if (team == "Croatia")
            {
                switch (souvenirs)
                {
                    case "flags":
                        flags += 2.75;
                        totalSpend = flags * countOfBoughtS;
                        break;

                    case "caps":
                        caps += 6.90;
                        totalSpend = caps * countOfBoughtS;
                        break;

                    case "posters":
                        posters += 4.95;
                        totalSpend = posters * countOfBoughtS;
                        break;

                    case "stickers":
                        stickers += 1.10;
                        totalSpend = stickers * countOfBoughtS;
                        break;
                }
            }
            else if (team == "Denmark")
            {
                switch (souvenirs)
                {
                    case "flags":
                        flags = 3.10;
                        totalSpend = flags * countOfBoughtS;
                        break;

                    case "caps":
                        caps = 6.50;
                        totalSpend = caps * countOfBoughtS;
                        break;

                    case "posters":
                        posters = 4.80;
                        totalSpend = posters * countOfBoughtS;
                        break;

                    case "stickers":
                        stickers = 0.90;
                        totalSpend = stickers * countOfBoughtS;
                        break;
                }
            }

            Console.WriteLine($"Pepi bought {countOfBoughtS} {souvenirs} of {team} for {totalSpend:f2} lv.");

            }
        }
    }
}
