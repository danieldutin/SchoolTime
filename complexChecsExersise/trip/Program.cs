using System;

namespace trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string typeOfAccomodation = "";
            string location = "";
            
            double cost = 0;


            if (budget <= 100)
            {
                location = "Somewhere in Bulgaria";
                switch (season)
                {
                    case "summer":
                        cost = budget * 0.30;
                        break;

                    case "winter":
                        cost = budget * 0.70;
                        break;

                }

            }
            else if (budget <= 1000 && budget > 100)
            {
                location = "Somewhere in Balkans";
                switch (season)
                {
                    case "summer":
                        cost = budget * 0.40;
                        break;

                    case "winter":
                        cost = budget * 0.80;
                        break;

                }
            }
            else
            {
                location = "Somewhere in Europe";
                cost = budget * 0.90;
            }

            if (season == "summer" && cost < 900)
            {
                typeOfAccomodation = "Camp";
            }
            else if (season == "winter" && cost < 900)
            {
                typeOfAccomodation = "Hotel";
            }else
            {
                typeOfAccomodation = "Hotel";
            }

            Console.WriteLine(location);
            Console.WriteLine($"{typeOfAccomodation} - {cost:f2}");

        }
    }
}
