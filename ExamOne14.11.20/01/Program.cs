using System;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            double videoCardPrice = double.Parse(Console.ReadLine());
            double adaptorPrice = double.Parse(Console.ReadLine());
            double electricityPerDay = double.Parse(Console.ReadLine());

            double profitPerDay = double.Parse(Console.ReadLine());
            
            double videoCardsTotal = videoCardPrice * 13;
            double adaptorsTotal = adaptorPrice * 13;



            double moneySpend = videoCardsTotal + adaptorsTotal + 1000;

            double videoCartDailyProfit = profitPerDay - electricityPerDay;
            double totalCardsPRofitPerDay = videoCartDailyProfit * 13;

            double repayInvestment = Math.Ceiling(moneySpend / totalCardsPRofitPerDay);
            Console.WriteLine(moneySpend);
            Console.WriteLine(repayInvestment);
        }
    }
}
