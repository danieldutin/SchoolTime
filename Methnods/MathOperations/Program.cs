using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberOne = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double numberTwo = double.Parse(Console.ReadLine());
            Console.WriteLine(Calculation(numberOne, operation, numberTwo));
            
        }
        static double Calculation(double a, string b, double c) 
        {
            double result = 0;
            switch (b)
            {
                case "+":
                    result = a + c;
                    break;
                case "-":
                    result = a - c;
                    break;
                case "*":
                    result = a * c;
                    break;
                case "/":
                    result = a / c;
                    break;
            }

            return result;

        }
    }
}
