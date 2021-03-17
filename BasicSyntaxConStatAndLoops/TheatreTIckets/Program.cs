using System;

namespace TheatreTIckets
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            int price = 0;

            if (age <= 18 && age>=0)
            {
                switch (day)
                {

                    case "weekday":
                        price = 12;
                        break;
                    case "weekend":
                        price = 15;
                        break;
                    case "holiday":
                        price = 5;
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }
            else if (age <= 64 && age > 18)
            {
                switch (day)
                {

                    case "weekday":
                        price = 18;
                        break;
                    case "weekend":
                        price = 20;
                        break;
                    case "holiday":
                        price = 12;
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }
            else if (age>64 && age <=122)
            {
                switch (day)
                {

                    case "weekday":
                        price = 12;
                        break;
                    case "weekend":
                        price = 15;
                        break;
                    case "holiday":
                        price = 10;
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error!");
                return;
            }
            if (price>0)
            {
                Console.WriteLine($"{price}$");
            }
            
        }
    }
}
