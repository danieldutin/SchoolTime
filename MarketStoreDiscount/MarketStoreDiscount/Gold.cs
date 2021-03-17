using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStoreDiscount
{
    class Gold: ICard
    {
        public double PurchaseValue { get; set; }
        public double Turnover { get; set; }
        public double DiscountRate { get; set; }
        public double Discount { get; set; }
        public double Total { get; set; }

        public void currentCustomer(double PurchaseValue, double Turnover, double DiscountRate, double Discount, double Total)
        {
            
            PurchaseValue = this.PurchaseValue;
            Turnover = this.Turnover;
            DiscountRate = this.DiscountRate;
            Discount = this.Discount;
            Total = this.Total;

        }
        public void GetCustomerProperties(Customer client)
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

            
        }

    }
}
