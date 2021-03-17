using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStoreDiscount
{
    interface ICard
    {
        void currentCustomer(double PurchaseValue, double Turnover, double DiscountRate, double Discount, double Total);


        void GetCustomerProperties(Customer client);

        
    }
}
