using System;

namespace summerClothes
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature = int.Parse(Console.ReadLine());
            string timeOftheDay = Console.ReadLine().ToLower();
            string outfit = "";
            string shoes = "";

            switch (timeOftheDay)
            {
                case "morning":

                    if (temperature >=10 && temperature <= 18 )
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    else if (temperature >18 && temperature <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    break;

                case "afternoon":

                    if (temperature >= 10 && temperature <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (temperature > 18 && temperature <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                    }
                    break;
                    
                case "evening":
                    
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    
                    break;
                   
            }
            Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}. ");
        }
    }
}
