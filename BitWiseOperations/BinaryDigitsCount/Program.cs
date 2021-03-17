using System;

namespace BinaryDigitsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int zeroOrOne = int.Parse(Console.ReadLine());

            int count = 0;

            while (number>0)
            {
                int leftover = number % 2;
                if (leftover == zeroOrOne)
                {
                    count++;
                }
                number /= 2;
            }

            Console.WriteLine(count);
        }
    }
}
