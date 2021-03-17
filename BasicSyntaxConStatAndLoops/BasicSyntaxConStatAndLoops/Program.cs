using System;

namespace BasicSyntaxConStatAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Good luck to me in 2021
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:f2}");
        }
    }
}
