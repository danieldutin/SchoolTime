using System;

namespace holiday
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double currentBalance = double.Parse(Console.ReadLine());

            int daysCounter = 0;
            int spendingCounter = 0;

            while (currentBalance < moneyNeeded)
            {
                string input = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                if (input == "spend")
                {
                    spendingCounter++;
                    if (money > currentBalance)
                    {
                        continue;
                    }
                    currentBalance -= money;
                }
                if (input == "save")
                {
                    currentBalance += money;
                    spendingCounter = 0;
                }

                daysCounter++;
            }

            if (spendingCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine($"{daysCounter}");
            }
            if (currentBalance >= moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {daysCounter} days.");
            }
        }
    }
}
