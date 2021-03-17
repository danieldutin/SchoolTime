using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class Card
    {
        public double PurchaseValue { get; set; }
        public double Turnover { get; set; }
        public double DiscountRate { get; set; }
        public double Discount { get; set; }
        public double Total { get; set; }

        public static double discount = 0;

        public virtual void GetOutput(Card current)
        {

            Console.WriteLine($"Purchase value:{current.PurchaseValue:f2}$");
            Console.WriteLine($"Discount rate:{current.DiscountRate:f2}%");
            Console.WriteLine($"Discount:{current.Discount:f2}$");
            Console.WriteLine($"Total:{current.Total:f2}$");
            Console.WriteLine();
        }

        public virtual void GetDiscountRate(Card client)
        {
            GetOutput(client);
        }

    }

}
