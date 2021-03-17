using System;

namespace schollarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            double minimumWage = double.Parse(Console.ReadLine());

            double scholarshipForExRes = Math.Floor(averageGrade * 25);
            double socialScolarship = Math.Floor(0.35 * minimumWage);

            if (income >= minimumWage && averageGrade >= 5.5)
            {
                Console.WriteLine($"You get a scholarship for excellent results {scholarshipForExRes} BGN");
            }
            else if (income >= minimumWage && averageGrade < 5.5)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (income < minimumWage&& averageGrade>5.5 && socialScolarship <= scholarshipForExRes)
            {
                Console.WriteLine($"You get a scholarship for excellent results {scholarshipForExRes} BGN");
            }
            else if (income < minimumWage && averageGrade < 4.5)
            {
                Console.WriteLine($"You get a Social scholarship {socialScolarship} BGN");
            }
            else if (income < minimumWage && averageGrade <= 4.5 )
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            
        }
    }
}
