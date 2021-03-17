using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int total = 0;
            for (int i = 0; i < n; i++)
            {
                int addLiters = int.Parse(Console.ReadLine());
                if (total+addLiters>255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                else
                {
                    total += addLiters;
                }
            }
            Console.WriteLine(total);

        }
    }
}
