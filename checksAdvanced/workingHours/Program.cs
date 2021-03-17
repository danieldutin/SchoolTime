using System;

namespace workingHours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            string dayOfTheWeek = Console.ReadLine().ToLower();

            if (hour < 10 || hour >18 || dayOfTheWeek == "sunday" )
            {
                Console.WriteLine("closed");
            }
            else
            {
                Console.WriteLine("open");
            }
        }
    }
}
