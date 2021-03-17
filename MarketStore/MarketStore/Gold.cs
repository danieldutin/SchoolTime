using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class Gold : Card
    {
        public override void GetDiscountRate(Card client)
        {
            if (client.Turnover < 100)
            {
                client.DiscountRate = 0.02;
                client.Discount = client.PurchaseValue * client.DiscountRate;
                client.Total = client.PurchaseValue - client.Discount;
            }
            else
            {
                double currentDiscountBonus = (Math.Floor(client.PurchaseValue / 100)) / 100;
                if (currentDiscountBonus > 0.08)
                {
                    currentDiscountBonus = 0.08;
                }
                client.DiscountRate = currentDiscountBonus + 0.02;
                client.Discount = client.PurchaseValue * client.DiscountRate;
                client.Total = client.PurchaseValue - client.Discount;
            }

            GetOutput(client);

        }
    }
}
