using System;

namespace Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string operation = Console.ReadLine().ToLower();
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            switch (operation)
            {
                case "add":
                    Add(first, second);
                    break;
                case "substract":
                    Substraction(first, second);
                    break;
                case "multiply":
                    Multiplication(first, second);
                    break;
                case "divide":
                    Divisiion(first, second);
                    break;

            }
        }
        static void Substraction(double a, double b)
        {
            Console.WriteLine(a - b);
        }
        static void Divisiion(double a, double b)
        {
            Console.WriteLine(a / b);
        }
        static void Add(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        static void Multiplication(double a, double b)
        {
            Console.WriteLine(a * b);
        }

    }
}
