using System;

namespace Vacantion
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();

            double pricePerDay = 0;
            double totalPrice = 0;

            if (groupType =="Students")
            {
                if (day =="Friday")
                {
                    pricePerDay += 8.45;
                }
                else if (day=="Saturday")
                {
                    pricePerDay += 9.80;
                }
                else
                {
                    pricePerDay += 10.46;
                }
                totalPrice = pricePerDay * peopleCount;

                if (peopleCount>=30)
                {
                    totalPrice -= totalPrice * 0.15;
                }

                
            }
            else if (groupType =="Business")
            {
                if (day == "Friday")
                {
                    pricePerDay += 10.90;
                }
                else if (day == "Saturday")
                {
                    pricePerDay += 15.60;
                }
                else
                {
                    pricePerDay += 16;
                }
                totalPrice = pricePerDay * peopleCount;
                if (peopleCount>=100)
                {
                    totalPrice += (10 * pricePerDay);
                }
            }
            else
            {
                if (day == "Friday")
                {
                    pricePerDay += 15;
                }
                else if (day == "Saturday")
                {
                    pricePerDay += 20;
                }
                else
                {
                    pricePerDay +=22.50;
                }
                totalPrice = pricePerDay * peopleCount;
                if (peopleCount>=10&&peopleCount<=20)
                {
                    totalPrice -= totalPrice * 0.05;
                }
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
