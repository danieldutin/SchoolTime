using System;

namespace balance
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double balance = 0;
            while (true)
            {
                string noMoreMoney = Console.ReadLine();
                
                if (noMoreMoney == "NoMoreMoney")
                {
                    break;
                }
                double increase = double.Parse(noMoreMoney);

                if (increase <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    balance += increase;
                    Console.WriteLine($"Increase: {increase:f2}");
                }
                
            }
            
            Console.WriteLine($"Total: {balance:f2}");
        }
    }
}
