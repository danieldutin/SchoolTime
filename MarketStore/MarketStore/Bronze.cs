using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class Bronze : Card
    {
        //public double PurchaseValue { get; set; }
        //public double Turnover { get; set; }
        //public double DiscountRate { get; set; }
        //public double Discount { get; set; }
        //public double Total { get; set; }

        //public static double discount = 0;

        //public override void GetOutput(Customer current)
        //{

        //    Console.WriteLine($"Purchase value:{current.PurchaseValue:f2}$");
        //    Console.WriteLine($"Discount rate:{current.DiscountRate:f2}%");
        //    Console.WriteLine($"Discount:{current.Discount:f2}$");
        //    Console.WriteLine($"Total:{current.Total:f2}$");
        //    Console.WriteLine();
        //}
        public override void GetDiscountRate(Card client)
        {

            if (client.Turnover < 100)
            {
                client.DiscountRate = 0;
                client.Total = client.PurchaseValue;

            }
            else if (client.Turnover >= 100 && client.Turnover <= 300)
            {
                client.DiscountRate = 0.01;
                client.Discount = client.PurchaseValue * client.DiscountRate;
                client.Total = client.PurchaseValue - client.Discount;
            }
            else
            {
                client.DiscountRate = 0.025;
                client.Discount = client.PurchaseValue * client.DiscountRate;
                client.Total = client.PurchaseValue - client.Discount;
            }

            GetOutput(client);
        }
    }
}
