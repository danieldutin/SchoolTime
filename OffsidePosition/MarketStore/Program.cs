//using System;
//using System.Linq;

//namespace MarketStore
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Customer bronzeCustomer = new Customer
//            {
//                PurchaseValue = 150.00,
//                Turnover = 0,
                
                
//            };
//            Customer silverCustomer = new Customer
//            {
//                PurchaseValue = 850.00,
//                Turnover = 600.00,
               
//            };
//            Customer goldCustomer = new Customer
//            {
//                PurchaseValue = 1300.00,
//                Turnover = 1500.00,
                
//            };

//            GetInfo(goldCustomer);
//            GetInfo(silverCustomer);
//            GetInfo(goldCustomer);

//        }

        

//        static void GetInfo(Customer client)
//        {


//            Console.WriteLine(client); 
           
//            Console.WriteLine($"Purchase value:{client.PurchaseValue:f2}$");
//            Console.WriteLine($"Discount rate:{client.DiscountRate:f2}%");
//            Console.WriteLine($"Discount:{client.Discount:f2}$");
//            Console.WriteLine($"Total:{client.Total:f2}$");
//            Console.WriteLine();

//            //GetCustomerDiscount(silver);
//            //Console.WriteLine("Silver:");
//            //Console.WriteLine($"Purchase value:{silver.PurchaseValue:f2}");
//            //Console.WriteLine($"Discount rate:{silver.DiscountRate:f2}");
//            //Console.WriteLine($"Discount:{silver.Discount:f2}");
//            //Console.WriteLine($"Total:{silver.Total:f2}");
//            //Console.WriteLine();

//            //GetCustomerDiscount(gold);
//            //Console.WriteLine("Gold:");
//            //Console.WriteLine($"Purchase value:{gold.PurchaseValue:f2}");
//            //Console.WriteLine($"Discount rate:{gold.DiscountRate:f2}%");
//            //Console.WriteLine($"Discount:{gold.Discount:f2}");
//            //Console.WriteLine($"Total:{gold.Total:f2}");
//            //Console.WriteLine();
//        }
//    }
//}
