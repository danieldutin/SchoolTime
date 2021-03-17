using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int difference = 0;
            int hours = 0;
            int minutes = 0;
            //preobrazuvane na chasove v minuti
            examMinutes += examHour * 60;
            arrivalMinutes += arrivalHour * 60;

            if (arrivalMinutes > examMinutes)
            {
                Console.WriteLine("Late");
                difference = Math.Abs(arrivalMinutes - examMinutes);

                if (difference < 60)
                {
                    Console.WriteLine($"{difference} minutes after the start");
                }
                else
                {
                    hours = Math.Abs(hours - difference / 60);
                    minutes = difference % 60;

                    Console.WriteLine($"{hours}:{minutes:d2} hours after the start");
                }
            }
            else if (arrivalMinutes < examMinutes - 30)
            {
                Console.WriteLine("Early");
                difference = examMinutes - arrivalMinutes;
                if (difference <60)
                {
                    Console.WriteLine($"{difference} minutes before the start");
                }
                else
                {
                    hours = difference / 60;
                    minutes = difference % 60;
                    Console.WriteLine($"{hours}:{minutes:d2} hours before the start");
                }

            }
            else
            {
                Console.WriteLine("On time");
                difference = examMinutes - arrivalMinutes;
                Console.WriteLine($"{difference} minutes before the start");
                   
            }
        }
    }
}
