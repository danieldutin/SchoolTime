using System;

namespace firstProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int ticketsCount = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            int cinemaPercentage = int.Parse(Console.ReadLine());

            double sumFromTickets = ticketsCount * ticketPrice;
            double sumForWholePeriod = sumFromTickets * days;
            double discount = sumForWholePeriod * cinemaPercentage / 100;
            double finalSum = sumForWholePeriod - discount;
            Console.WriteLine($"The profit from the movie {movieName} is {finalSum:f2} lv.");
        }
    }
}
