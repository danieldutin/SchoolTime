using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double measurement = double.Parse(Console.ReadLine());
            string typeInput = Console.ReadLine();
            string typeOutput = Console.ReadLine();

            if (typeInput == "mm")
            {
                if (typeOutput == "cm")
                {
                    double convertion = measurement * 0.01;
                    Console.WriteLine($"{convertion:f3}");
                }
                else
                {
                    double convertion = measurement * 0.001;
                    Console.WriteLine($"{convertion:f3}");
                }
               

            }
            else if (typeInput == "cm")
            {
                if (typeOutput == "mm")
                {
                    double convertion = measurement * 10;
                    Console.WriteLine($"{convertion:f3}");
                }
                else
                {
                    double convertion = measurement * 0.01;
                    Console.WriteLine($"{convertion:f3}");
                }
            }
            else
            {
                if (typeOutput == "mm")
                {
                    double convertion = measurement * 1000;
                    Console.WriteLine($"{convertion:f3}");
                }
                else
                {
                    double convertion = measurement * 100;
                    Console.WriteLine($"{convertion:f3}");
                }
            }
        }
    }
}
