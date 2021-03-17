using System;

namespace smallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputProduct = Console.ReadLine().ToLower();
            string inputCity = Console.ReadLine().ToLower();
            double amount = double.Parse(Console.ReadLine());
            string price = ""; 
            if (inputCity == "sofia")
            {
                switch (inputProduct)
                {
                    case "coffee":
                        price = (amount * 0.50).ToString();
                        break;
                    case "water":
                        price = (amount * 0.80).ToString();
                        break;
                    case "beer":
                        price = (amount * 1.20).ToString();
                        break;
                    case "sweets":
                        price = (amount * 1.45).ToString();
                        break;
                    case "peanuts":
                        price = (amount * 1.60).ToString();
                        break;
                    default:
                        Console.WriteLine("UNKNOWN");
                        break;
                }
            }
            else if (inputCity == "varna")
            {
                switch (inputProduct)
                {
                    case "coffee":
                        price = (amount * 0.45).ToString();
                        break;
                    case "water":
                        price = (amount * 0.70).ToString();
                        break;
                    case "beer":
                        price = (amount * 1.10).ToString();
                        break;
                    case "sweets":
                        price = (amount * 1.35).ToString();
                        break;
                    case "peanuts":
                        price = (amount * 1.55).ToString();
                        break;
                    default:
                        Console.WriteLine("UNKNOWN");
                        break;
                }
            }
            else if (inputCity == "plovdiv")
            {
                switch (inputProduct)
                {
                    case "coffee":
                        price = (amount * 0.40).ToString();
                        break;
                    case "water":
                        price = (amount * 0.70).ToString();
                        break;
                    case "beer":
                        price = (amount * 1.15).ToString();
                        break;
                    case "sweets":
                        price = (amount * 1.30).ToString();
                        break;
                    case "peanuts":
                        price = (amount * 1.50).ToString();
                        break;
                    default:
                        Console.WriteLine("UNKNOWN");
                        break;
                }
                

            }
            Console.WriteLine(price);
        }
    }
}
