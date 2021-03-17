using System;

namespace traveling
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
           

            while (true)
            {
                
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                double budged = double.Parse(Console.ReadLine());
                double savings = 0;
                while (savings < budged)
                {
                    double income = double.Parse(Console.ReadLine());
                   
                   
                    savings += income;
                }
                Console.WriteLine($"Going to {input}!");
            }
        }
    }
}
