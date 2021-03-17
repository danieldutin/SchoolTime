using System;

namespace histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            const double doubleConverter = 1.0;
            int number = int.Parse(Console.ReadLine());
            int p1 = 0;
            int p2 = 0;
            int p3 = 0;
            int p4 = 0;
            int p5 = 0;

            


            for (int i = 0; i < number; i++)
            {
                int newNumber = int.Parse(Console.ReadLine());

                if (newNumber < 200)
                {
                    p1++;
                }
                else if (newNumber < 400)
                {
                    p2++;
                }
                else if (newNumber < 600)
                {
                    p3++;
                }
                else if (newNumber < 800)
                {
                    p4++;
                }
                else
                {
                    p5++;
                }

            }

            double pp1 = doubleConverter * p1 / number * 100;
            double pp2 = doubleConverter * p2 / number * 100;
            double pp3 = doubleConverter * p3 / number * 100;
            double pp4 = doubleConverter * p4 / number * 100;
            double pp5 = doubleConverter * p5 / number * 100;

            Console.WriteLine($"{pp1:f2}%");
            Console.WriteLine($"{pp2:f2}%");
            Console.WriteLine($"{pp3:f2}%");
            Console.WriteLine($"{pp4:f2}%");
            Console.WriteLine($"{pp5:f2}%");
        }
    }
}
