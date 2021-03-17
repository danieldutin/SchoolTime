using System;

namespace sumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumN = 0;
            while (number > sumN)
            {
                int additives = int.Parse(Console.ReadLine());
                sumN += additives;
            }
            Console.WriteLine(sumN);
        }
    }
}
