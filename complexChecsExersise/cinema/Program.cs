using System;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            const double premiereTicket = 12.00;
            const double normalTicket = 7.50;
            const double discountTicket = 5.00;

            string typeOfMovie = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            double totalMoney = 0;

            switch (typeOfMovie)
            {
                case "premiere":
                    totalMoney = rows * colums * premiereTicket;
                    break;
                case "normal":
                    totalMoney = rows * colums * normalTicket;
                    break;
                case "discount":
                    totalMoney = rows * colums * discountTicket;
                    break;
            }

            Console.WriteLine($"{totalMoney:f2} leva");

        }
    }
}
