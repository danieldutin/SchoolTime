//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace MarketStore
//{
//    class Customer
//    {
       
//        public double PurchaseValue { get; set; }
//        public double Turnover { get; set; }
//        public double DiscountRate { get; set; }
//        public double Discount { get; set; }
//        public double Total { get; set; }

//        //public DiscountFinder card { get; set; }

//        //public static Customer GetCustomerDiscount(Customer customer)
//        //{
//            static DiscountFinder GetGoldCard(Customer customer)
//            {

//                customer.Discount = DiscountFinder.GetGoldDiscount(customer);
//                customer.DiscountRate *= 100;
//                customer.Total = customer.PurchaseValue - customer.Discount;

//                return customer;
//            }
//            static DiscountFinder GetSilverCard(Customer customer)
//            {

//                customer.Discount = DiscountFinder.GetSilverDiscount(customer);
//                customer.DiscountRate *= 100;
//                customer.Total = customer.PurchaseValue - customer.Discount;

//                return customer;
//            }
//            static DiscountFinder GetBronzeCard(Customer customer)
//            {

//                customer.Discount = DiscountFinder.GetBronzeDiscount(customer);
//                customer.DiscountRate *= 100;
//                customer.Total = customer.PurchaseValue - customer.Discount;

//                return customer;
//            }

//       // }

//    }
    

//}
