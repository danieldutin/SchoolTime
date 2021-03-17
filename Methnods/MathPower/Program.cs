using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(MathPower(n, power));
        }

        static double MathPower(double n, double m)
        {
            double result = 1;

            for (int i = 1; i <= m; i++)
            {
                result = result * n;
    
            }
            return result;
        }

        
    }
}
