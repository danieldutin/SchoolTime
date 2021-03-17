using System;

namespace CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine().ToLower();
            if (day == "monday" || day == "tuesday" || day == "friday")
            {
                Console.WriteLine(12);
            }
            else if (day == "wednesday" || day == "thursday")
            {
                Console.WriteLine(14);
            }
            else
            {
                Console.WriteLine(16);
            }
        }
    }
}
