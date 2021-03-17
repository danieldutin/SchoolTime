using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Controller(grade);
        }
        static void Controller(double grade)
        {
            if (grade<3)
            {
                Console.WriteLine("Fail");
            }
            else if (3<=grade&& grade < 3.50)
            {
                Console.WriteLine("Poor");
            }
            else if (3.50 <= grade && grade < 4.50)
            {
                Console.WriteLine("Good");
            }
            else if (4.50 <= grade && grade < 5.50)
            {
                Console.WriteLine("Very good");
            }
            else
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
