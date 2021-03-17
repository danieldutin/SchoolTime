using System;

namespace weekendOrWorkingdayBrooo
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeek = Console.ReadLine().ToLower();
           
            switch (dayOfWeek)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                    Console.WriteLine("Working day");
                    break;
                case "Sunday":

                case "Saturday":
                    Console.WriteLine("Weekend");
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            
        }
    }
}

