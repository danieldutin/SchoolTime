using System;

namespace newHome
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlowers = Console.ReadLine();
            double numberOFflowers = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double flowerPrice = 0;
            double moneyLeft = 0;
            double moneyNeeded = 0;

            switch (typeOfFlowers)
            {
                case "Roses":
                    if (numberOFflowers > 80)
                    {
                        flowerPrice = (numberOFflowers * 5) - ((numberOFflowers * 5) * 10 / 100);
                    }
                    else
                    {
                        flowerPrice = numberOFflowers * 5;
                    }

                    break;

                case "Dahlias":

                    if (numberOFflowers > 90)
                    {
                        flowerPrice = (numberOFflowers * 3.80) - ((numberOFflowers * 3.80) * 15 / 100);
                    }
                    else
                    {
                        flowerPrice = numberOFflowers * 3.80;
                    }
                    break;

                case "Tulips":
                    if (numberOFflowers > 80)
                    {
                        flowerPrice = (numberOFflowers * 2.80) - ((numberOFflowers * 2.80) * 15 / 100);
                    }
                    else
                    {
                        flowerPrice = numberOFflowers * 2.80;
                    }
                    break;

                case "Narcissus":
                    if (numberOFflowers < 120)
                    {
                        flowerPrice = (numberOFflowers * 3) + ((numberOFflowers * 3) * 15 / 100);
                    }
                    else
                    {
                        flowerPrice = numberOFflowers * 3;
                    }
                    break;

                case "Gladiolus":

                    if (numberOFflowers < 80)
                    {
                        flowerPrice = (numberOFflowers * 2.5) + ((numberOFflowers * 2.5) * 20 / 100);
                    }
                    else
                    {
                        flowerPrice = numberOFflowers * 2.5;
                    }

                    break;
            }

            if (flowerPrice <= budget)
            {
                moneyLeft = budget - flowerPrice;

                Console.WriteLine($"Hey, you have a great garden with {numberOFflowers} {typeOfFlowers} and {moneyLeft :f2} leva left.");
            }
            else
            {
                moneyNeeded = flowerPrice - budget;
                Console.WriteLine($"Not enough money, you need {moneyNeeded:f2} leva more.");
            }

            
        }
    }
}
