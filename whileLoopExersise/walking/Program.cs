using System;

namespace walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSteps = 0;
            int walkedSteps = 0;
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    input = Console.ReadLine();
                    walkedSteps = int.Parse(input);
                    totalSteps += walkedSteps;
                    if (totalSteps < 10000)
                    {
                        Console.WriteLine($"{Math.Abs(10000 - totalSteps)} more steps to reach goal.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        Console.WriteLine($"{Math.Abs(totalSteps - 10000)} steps over the goal!");
                        break;
                    }

                }
                walkedSteps = int.Parse(input);
                totalSteps += walkedSteps;
                if (totalSteps > 10000)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    Console.WriteLine($"{Math.Abs(totalSteps - 10000)} steps over the goal!");
                    break;
                }


            }
        }
    }
}
