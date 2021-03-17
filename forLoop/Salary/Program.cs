using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabs = int.Parse(Console.ReadLine());
            int startingSalary = int.Parse(Console.ReadLine());

            for (int i = 0; i < tabs; i++)
            {
                string domain = Console.ReadLine();

                if (domain == "Facebook")
                {
                    startingSalary -= 150; ;
                }
                if (domain == "Instagram")
                {
                    startingSalary -= 100;
                }
                if (domain == "Reddit")
                {
                    startingSalary -= 50;
                }
                if (startingSalary == 0)
                {
                    Console.WriteLine("You have lost your salary.");
                }
            }

            if (startingSalary > 0)

            {
                Console.WriteLine(startingSalary);
            }
        }
    }
}
