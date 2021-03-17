using System;

namespace OddEvenPostition
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            
            
            double EvenSum = 0;
            double EvenMin = double.MaxValue;
            double EvenMax = double.MinValue;

            double OddSum = 0;
            double OddMin = double.MaxValue;
            double OddMax = double.MinValue;


            for (int i = 1; i <= input; i++)
            {
                double current = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    EvenSum += current;
                    if (current < EvenMin)
                    {
                        EvenMin = current;
                    }

                    if (current > EvenMax)
                    {
                        EvenMax = current;
                    }
                }
                else
                {
                    OddSum += current;
                    if (current < OddMin)
                    {
                        OddMin = current;
                    }

                    if (current > OddMax)
                    {
                        OddMax = current;
                    }
                }
            }

            Console.WriteLine($"OddSum={OddSum:f2},");
            if (OddSum == 0)
            {
                Console.WriteLine($"OddMin=No,");
                Console.WriteLine($"OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={OddMin:f2},");
                Console.WriteLine($"OddMax={OddMax:f2},");
            }
            Console.WriteLine($"EvenSum={EvenSum:f2},");
            if (EvenSum == 0)
            {
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={EvenMin:f2},");
                Console.WriteLine($"EvenMax={EvenMax:f2}");
            }
        }
    }
}
