using System;

namespace lunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int episodeLenght = int.Parse(Console.ReadLine());
            int breakLenght = int.Parse(Console.ReadLine());

            double timeForLunch = breakLenght * 1.0 / 8;
            double timeForBreak = breakLenght * 1.0 / 4;
            double timeLeft = breakLenght - timeForLunch - timeForBreak;

            if (timeLeft >= episodeLenght)
            {
                
                Console.WriteLine($"You have enough time to watch {name} and left with {Math.Ceiling(timeLeft)} minutes free time.");
            }
            else
            {
                double needed = Math.Ceiling(episodeLenght - timeLeft);
                Console.WriteLine($"You don't have enough time to watch {name}, you need {needed} more minutes.");
            }

        }
    }
}
