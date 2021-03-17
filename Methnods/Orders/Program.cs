using System;

namespace Orders
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            int qty = int.Parse(Console.ReadLine());
            double price = SwitchCase(product,qty);
            
            Console.WriteLine($"{price:f2}");
            
        }
        static double SwitchCase(string product, int amount) 
        {
            double currentprice = 0;
            double total = 0;
            switch (product)
            {
                case "coffee":
                    currentprice += 1.50;
                    return total = currentprice * amount;


                case "water":
                     currentprice += 1.00;
                    return total = currentprice * amount;

                case "coke":
                    currentprice += 1.40;
                    return total = currentprice * amount;

                case "snacks":
                    currentprice += 2.00;
                    return total = currentprice * amount;
                default:
                    return currentprice = 0;
            }


        }
    }
}
