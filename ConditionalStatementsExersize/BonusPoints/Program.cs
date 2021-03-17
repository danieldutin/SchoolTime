using System;

namespace BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int startingPoints = int.Parse(Console.ReadLine());
            double bonus = 0.0;
            if (startingPoints <= 100)
            {
                bonus = 5;
            }
            else if (startingPoints > 1000)
            {
                bonus = startingPoints * 0.1;
            }
            else
            {
                bonus = startingPoints * 0.2;
            }

            if (startingPoints % 2 == 0)
            {
                bonus += 1;
            }
            else if (startingPoints % 10 == 5)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(startingPoints + bonus);
        }
    }
}   
