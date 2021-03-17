using System;

namespace vetParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            double dayTax = 0;
            double total = 0;
            for (int day = 1; day <= days; day++)
            {
                for (int hours = 1; hours <= hour; hours++)
                {
                    if (day % 2 == 0 && hours %2 !=0)
                    {
                        dayTax += 2.50;
                    }
                    else if (day %2 !=0 && hours %2==0)
                    {
                        dayTax += 1.25;
                    }
                    else
                    {
                        dayTax += 1;
                    }
                }

                Console.WriteLine($"Day: {day} - {dayTax:f2} leva");
                total += dayTax;
                dayTax = 0; 
            }
            Console.WriteLine($"Total: {total:f2} leva");
        }
    }
}
