using System;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine((GetMultipleOfEvenAndOdds(GetSumOfOddDigits(number), GetSumOfEvenDigits(number))));
        }

        static int GetMultipleOfEvenAndOdds(int n, int m)
        {
            return n * m;
        }
        static int GetSumOfEvenDigits(int n)
        {
            string converter = n.ToString();
            int current = 0;
            int sumEven = 0;
            for (int i = 1; i <= converter.Length; i++)
            {
                current = n % 10;
                
                if (current % 2 == 0)
                {
                    
                }
                else
                {
                    sumEven += current;
                }
                n = n / 10;
            }
            return sumEven;
        }
        static int GetSumOfOddDigits(int n)
        {
            string converter = n.ToString();
            int current = 0;
            int sumOdds = 0;           
            for (int i = 1; i <= converter.Length; i++)
            {
                
                current = n % 10;
                if (current % 2 == 0)
                {
                    sumOdds += current;
                }
                n = n / 10;
            }
            return sumOdds;
        }

    }
}
