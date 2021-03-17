using System;

namespace cleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int lilysAge = int.Parse(Console.ReadLine());
            double washersPrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());
            double presentMoney = 10;
            double totalMoney = 0;
            double countOfToys = 0;
            
            
            for (int i = 1; i <= lilysAge; i++)
            {
                
                if (i % 2 == 0)
                {
                    totalMoney += presentMoney;
                    presentMoney += 10;
                    totalMoney -= 1;
                }
                else
                {
                    countOfToys += 1;
                }
            }

            totalMoney += countOfToys * toysPrice;

            if (washersPrice <= totalMoney)
            {
                Console.WriteLine($"Yes! {totalMoney - washersPrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washersPrice - totalMoney:f2}");
            }
        }
    }
}
