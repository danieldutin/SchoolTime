using System;

namespace IfElseLiveDemo
{
    class ConsoleChecksBrooo
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent"); ;
            }
            else
            {
                Console.WriteLine("bad");
            }


        }
    }
}
