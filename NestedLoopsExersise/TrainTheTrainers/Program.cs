using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int jouryCount = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int count = 0;
            double averageGrade = 0;
            double currentAverage = 0;
            double average = 0;
            while (command!= "Finish")
            {

                currentAverage = 0;
                for (int i = 1; i <= jouryCount; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    currentAverage += grade;
                    averageGrade += grade;
                    count++;
                }
                average = currentAverage / jouryCount;
                Console.WriteLine($"{command} - {average:f2}.");
                command = Console.ReadLine();
            }
            averageGrade = averageGrade / count;
            Console.WriteLine($"Student's final assessment is {averageGrade:f2}.");
        }
    }
}
