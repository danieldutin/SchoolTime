using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            if ((minutes + 15) >= 60)
            {

                hours += 1;
                minutes -= 60;
            }
            if (hours >= 24)
            {
                hours = 0;
            }

            Console.WriteLine($"{hours}:{minutes + 15:d2}");

        }
    }
    
}
