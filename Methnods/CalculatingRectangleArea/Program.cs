using System;

namespace CalculatingRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            
            Console.WriteLine(GetReactangleArea(height, width));

        }

        static double GetReactangleArea(double h, double w)
        {
            return h * w;
        }
    }
}
