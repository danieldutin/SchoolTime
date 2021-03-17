using System;
using System.Collections.Generic;
using System.Text;

namespace Customers
{
    interface GenericCard 
    {
        //public static double tierOneDiscount = 0.01;
        //public static double tierTwoDiscount = 0.02;
        //public static double tierThreeDiscount = 0.025;
        //public static double tierFourDiscount = 0.03;
        //public static double tierFiveDiscount = 0.035;
        public static double Turnover { get; set; }

        public static double PurchseValue { get; set; }
        public static double DiscountRate { get; set; }
        public static double Discount { get; set; }
        public static double Total { get; set; }

        public static double discount = 0;
        public static GenericCard GetBronzeDiscount(GenericCard client)
        {
            new Cards Bronze
            if (GenericCard.Turnover < 100)
            {
                GenericCard.DiscountRate = 0;
                return discount = 0;

            }
            else if (GenericCard.Turnover >= 100 && GenericCard.Turnover <= 300)
            {
                GenericCard.DiscountRate = 0.01;
                return discount = GenericCard.PurchaseValue * GenericCard.DiscountRate;
            }
            else
            {
                GenericCard.DiscountRate = 0.025;
                return discount = GenericCard.PurchaseValue * GenericCard.DiscountRate;
            }
        }
        public static double GetSilverDiscount(GenericCard client)
        {
            if (client.Turnover > 300)
            {
                client.DiscountRate = 0.035;
                return discount = client.PurchaseValue * client.DiscountRate;
            }
            else
            {
                client.DiscountRate = 0.02;
                return discount = client.PurchaseValue * client.DiscountRate;
            }
        }
        public static double GetGoldDiscount(Customer client)
        {
            if (client.Turnover < 100)
            {
                client.DiscountRate = 0.02;
                return discount = client.PurchaseValue * client.DiscountRate;
            }
            else
            {
                double currentDiscountBonus = (Math.Floor(client.PurchaseValue / 100)) / 100;
                if (currentDiscountBonus > 0.08)
                {
                    currentDiscountBonus = 0.08;
                }
                client.DiscountRate = currentDiscountBonus + 0.02;
                return discount = client.PurchaseValue * client.DiscountRate;
            }
        }
    }
}
