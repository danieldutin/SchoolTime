using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class DiscountFinder : Customer
    {
        //public static double tierOneDiscount = 0.01;
        //public static double tierTwoDiscount = 0.02;
        //public static double tierThreeDiscount = 0.025;
        //public static double tierFourDiscount = 0.03;
        //public static double tierFiveDiscount = 0.035;

        public static double discount = 0;
        public static double GetBronzeDiscount(Customer client)
        {

            if (client.Turnover < 100)
            {
                client.DiscountRate = 0;
                return discount = 0;

            }
            else if (client.Turnover >= 100 && client.Turnover <= 300)
            {
                client.DiscountRate = 0.01;
                return discount = client.PurchaseValue * client.DiscountRate;
            }
            else
            {
                client.DiscountRate = 0.025;
                return discount = client.PurchaseValue * client.DiscountRate;
            }
        }
        public static double GetSilverDiscount(Customer client)
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
