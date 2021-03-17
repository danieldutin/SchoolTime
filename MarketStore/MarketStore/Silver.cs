using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class Silver: Card
    {
            public override void GetDiscountRate(Card client)
        {
            if (client.Turnover > 300)
            {
                client.DiscountRate = 0.035;
                client.Discount = client.PurchaseValue * client.DiscountRate;
                client.Total = client.PurchaseValue - client.Discount;
            }
            else
            {
                client.DiscountRate = 0.02;
                client.Discount = client.PurchaseValue * client.DiscountRate;
                client.Total = client.PurchaseValue - client.Discount;
            }

            GetOutput(client);
        }
    }
}
