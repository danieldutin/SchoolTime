﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStoreDiscountCard
{
    class Bronze: ICard
    {
        public double PurchaseValue { get; set; }
        public double Turnover { get; set; }
        public double DiscountRate { get; set; }
        public double Discount { get; set; }
        public double Total { get; set; }

        public void GetDiscountRate(ICard client)
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


        }

        

    }
}
