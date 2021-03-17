using System;

namespace MidExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double priceOrder = 0;
            double total = 0;
            for (int i = 0; i < n; i++)
            {
                double price = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsuleCount = int.Parse(Console.ReadLine());

                priceOrder = (price*capsuleCount) * days;
                Console.WriteLine($"The price for the coffee is: ${priceOrder:f2}");
                total += priceOrder;
                
            }

            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
