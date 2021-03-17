using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Card bronze = new Bronze()
            {
                PurchaseValue = 150.00,
                Turnover = 0
            };
            Card silver = new Silver()
            {
                PurchaseValue = 850.00,
                Turnover = 600.00
            };
            Card gold = new Gold()
            {
                PurchaseValue = 1300.00,
                Turnover = 1500.00
            };


            bronze.GetDiscountRate(bronze);
            silver.GetDiscountRate(silver);
            gold.GetDiscountRate(gold);


        }

       
    }
}
