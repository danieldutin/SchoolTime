using System;

namespace DayOfTheWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            //below is array with literal declaration
            string[] daysOfTheWeek = new string[8] 
            {
                "Invalid day!",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            // Below is the option without array literal
            //daysOfTheWeek[0] = "Invalid day!";
            //daysOfTheWeek[1] = "Monday";
            //daysOfTheWeek[2] = "Tuesday";
            //daysOfTheWeek[3] = "Wednesday";
            //daysOfTheWeek[4] = "Thursday";
            //daysOfTheWeek[5] = "Friday";
            //daysOfTheWeek[6] = "Saturday";
            //daysOfTheWeek[7] = "Sunday";

            int index = int.Parse(Console.ReadLine());
            if (index>7||index<1)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(daysOfTheWeek[index]);
            }
            
        }
    }
}
