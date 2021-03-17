using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (isTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }

        }

        static bool isTopNumber(int number)
        {
            return isDivisibleBy(number, 8) && ContainsOddDigits(number);
        }

        private static bool ContainsOddDigits(int number)
        {
            while (number !=0)
            {
                int lastdigit = number % 10;
                if (lastdigit % 2 !=0)
                {
                    return true;

                }
                number /= 10;
            }
            return false;
        }
        private static bool isDivisibleBy(int number, int divider)
        {
            int sum = 0;

            while (number!=0)
            {
                int lastDigit = number % 10;
                sum += lastDigit;

                number /= 10;
            }
            return sum % divider == 0;
        }
    }
}
