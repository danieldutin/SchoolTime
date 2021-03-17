using System;

namespace _06
{
    class Program
    {
        static void Main(string[] args)
        {
            int locationCount = int.Parse(Console.ReadLine());
            double actualPerDay = 0;
            double averagePerday = 0;
            double need = 0;

            int daysCount = 0;
            for (int i = 1; i <= locationCount; i++)
            {
                double averageExpected = double.Parse(Console.ReadLine());
                int daysPerLocation = int.Parse(Console.ReadLine());
                for (int j = 1; j <= daysPerLocation; j++)
                {
                    double input = double.Parse(Console.ReadLine());


                    actualPerDay += input;
                    daysCount++;
                    
                }
                averagePerday = actualPerDay / daysCount;
                if (averagePerday >= averageExpected)
                {
                    Console.WriteLine($"Good job! Average gold per day: {averagePerday:f2}.");
                }
                else
                {
                    need = averageExpected - averagePerday;
                    Console.WriteLine($"You need {need:f2} gold.");
                }

                actualPerDay = 0;
                daysCount = 0;
                
            }

        }
    }
}
