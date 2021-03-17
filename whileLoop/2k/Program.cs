using System;

namespace _2k
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double sum = 1;
            
            while (number >= sum)
            {
                Console.WriteLine(sum);
                sum = (sum * 2) + 1;
               
            }
        }
    }
}
