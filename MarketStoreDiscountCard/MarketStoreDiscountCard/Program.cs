using System;

namespace MarketStoreDiscountCard
{
    class Program
    {
        static void Main(string[] args)
        {
            ICard bronze = new Bronze()
            {
                PurchaseValue = 150.00,
                Turnover = 0
            };

            ICard silver = new Silver()
            {
                PurchaseValue = 850.00,
                Turnover = 600.00
            };

            ICard gold = new Gold()
            {
                PurchaseValue = 1300.00,
                Turnover = 1500.00
            };
          
            GetOutput(bronze);
            GetOutput(silver);
            GetOutput(gold);

        }

        public static void GetOutput(ICard current) 
        {
            current.GetDiscountRate(current);

            Console.WriteLine($"Purchase value:{current.PurchaseValue:f2}$");
            Console.WriteLine($"Discount rate:{current.DiscountRate:f2}%");
            Console.WriteLine($"Discount:{current.Discount:f2}$");
            Console.WriteLine($"Total:{current.Total:f2}$");
            Console.WriteLine();
        }
    }
}
