using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStoreDiscountCard
{
    interface ICard
    {
        public double PurchaseValue { get; set; }
        public double Turnover { get; set; }
        public double DiscountRate { get; set; }
        public double Discount { get; set; }
        public double Total { get; set; }

        void GetDiscountRate(ICard client);

    }
}