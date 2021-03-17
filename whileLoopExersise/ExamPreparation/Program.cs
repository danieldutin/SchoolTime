using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxAlowedLowGrades = int.Parse(Console.ReadLine());

            int counter = 0;
            int badGradesCount = 0;
            int gradesSum = 0;
            string problemName = "";

            while (true)
            {
                problemName = Console.ReadLine();
                if (problemName == "Enough")
                {

                    Console.WriteLine($"Average score: {gradesSum / counter:f2} ");
                    Console.WriteLine($"Number of problems: {counter}");
                    Console.WriteLine($"Last problem: {problemName}");

                }
                counter++;
                int currentGrade = int.Parse(Console.ReadLine());
                gradesSum = gradesSum + currentGrade;
                if (currentGrade <= 4)
                {
                    badGradesCount++;
                }
                if (badGradesCount >= maxAlowedLowGrades)
                {
                    Console.WriteLine($"You need a break, {badGradesCount} poor grades.");
                    break;
                }
            }
        }
    }
}
